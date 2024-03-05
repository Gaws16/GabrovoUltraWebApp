var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

//string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContext<GabrovoUltraContext>
//    (options => options.UseSqlServer(connectionString));
builder.Services.AddApplicationDbContext(builder.Configuration);

builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddApplicationServices();

builder.Services.AddCustomServices();

//builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
//{
//    options.Password.RequireDigit = true;
//    options.Password.RequireLowercase = false;
//    options.Password.RequireUppercase = false;
//    options.Password.RequireNonAlphanumeric = false;
//    options.Password.RequiredLength = 6;
//})
//    .AddEntityFrameworkStores<GabrovoUltraContext>()
//    .AddDefaultTokenProviders();

//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}
//).AddJwtBearer(options =>
//{
//    options.TokenValidationParameters = new TokenValidationParameters()
//    {
//        ValidateActor = true,
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        RequireExpirationTime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = builder.Configuration.GetSection("Jwt:Issuer").Value,
//        ValidAudience = builder.Configuration.GetSection("Jwt:Audience").Value,
//        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("Jwt:Key").Value))
//    };


//});
//builder.Services.AddAuthorization();

//fix cors
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CorsPolicy", 
//        builder => 
//        builder.AllowAnyMethod()
//        .AllowAnyHeader()
//        .AllowAnyOrigin());
//});






//builder.Services.AddTransient<IAuthService, AuthService>();

//builder.Services.AddSwaggerGen();

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
