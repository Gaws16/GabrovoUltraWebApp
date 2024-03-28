
using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data;
using GabrovoUltraWebApp.Core.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using GabrovoUltraWebApp.Infrastructure.AutoMapperProfiles;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using Microsoft.OpenApi.Models;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
            services.AddScoped<IHeroSectionService, HeroSectionService>();
            services.AddScoped<IRepository,  Repository>();
            services.AddScoped<IRunnerService, RunnerService>();
            services.AddScoped<IRaceService, RaceService>();
            services.AddScoped<IDistanceService, DistanceService>();
            services.AddAutoMapper(typeof(AutoMapperProfiles));
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Gabrovo Ultra API",
                    Version = "v1"
                });
                options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
                {
                    Name = JwtBearerDefaults.AuthenticationScheme,
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    BearerFormat = "JWT",
                    Description = "Enter 'Bearer' [space] and then your token in the text input below. Example: 'Bearer 12345abcdef.....'"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = JwtBearerDefaults.AuthenticationScheme
                            },
                            Scheme = "Oauth2",
                            Name = JwtBearerDefaults.AuthenticationScheme,
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
            });
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<GabrovoUltraContext>(options =>
                options.UseSqlServer(connectionString));



            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
            })
    .AddEntityFrameworkStores<GabrovoUltraContext>()
    .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }
            ).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateActor = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    RequireExpirationTime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = config.GetSection("Jwt:Issuer").Value,
                    ValidAudience = config.GetSection("Jwt:Audience").Value,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("Jwt:Key").Value))
                };


            });
            services.AddAuthorization();
            return services;
        }

        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    builder.AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowAnyOrigin());
            });
        }
    }
}