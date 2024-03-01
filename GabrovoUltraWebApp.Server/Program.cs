using GabrovoUltraWebApp.Server.Data;
using GabrovoUltraWebApp.Server.Services;
using GabrovoUltraWebApp.Server.Services.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<GabrovoUltraContext>
    (options => options.UseSqlServer(connectionString));

builder.Services.AddAuthentication(options=>
{
    options.DefaultAuthenticateScheme =JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }
).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateActor = true,
        ValidateIssuer = true,
        ValidateAudience = true,
        RequireExpirationTime=true,
        ValidateIssuerSigningKey=true,
        ValidIssuer=builder.Configuration.GetSection("Jwt:Issuer").Value,
        ValidAudience=builder.Configuration.GetSection("Jwt:Audience").Value,

    };
    
   });
builder.Services.AddAuthorization();

//fix cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", 
        builder => 
        builder.AllowAnyMethod()
        .AllowAnyHeader()
        .AllowAnyOrigin());
});




builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
})
    .AddEntityFrameworkStores<GabrovoUltraContext>()
    .AddDefaultTokenProviders();
                                           
builder.Services.AddTransient<IAuthService, AuthService>();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapIdentityApi<IdentityUser>();

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
