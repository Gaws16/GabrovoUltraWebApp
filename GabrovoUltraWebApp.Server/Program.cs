using GabrovoUltraWebApp.Infrastructure.Data;
using GabrovoUltraWebApp.Server.Middleware;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);


//TODO: Move this to a config file
var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .MinimumLevel.Information()
    .WriteTo.File("Logs/GabrovoUltraLog-.txt",Serilog.Events.LogEventLevel.Warning,
    rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Services.AddSerilog(logger);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddApplicationDbContext(builder.Configuration);

builder.Services.AddApplicationIdentity(builder.Configuration);

builder.Services.AddApplicationServices();

builder.Services.AddCustomServices();



var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionsHandlerMiddleware>();

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    var context = services.GetRequiredService<GabrovoUltraContext>();
//    context.Database.Migrate();
//}
    app.MapFallbackToFile("/index.html");

app.Run();
