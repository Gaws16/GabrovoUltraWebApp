using System.Net;

namespace GabrovoUltraWebApp.Server.Middleware
{
    public class ExceptionsHandlerMiddleware
    {
        private readonly ILogger<ExceptionsHandlerMiddleware> logger;
        private readonly RequestDelegate next;

        public ExceptionsHandlerMiddleware(ILogger<ExceptionsHandlerMiddleware> _logger, RequestDelegate _next)
        {
            logger = _logger;
            next = _next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var errorId = Guid.NewGuid();

                logger.LogError(ex,"{@errorId} : {@message}"
                    ,errorId,message);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var response = new 
                {
                    Id = errorId,
                    ErrorMessage = "An unexpected error occurred, our team is currently working on resolving it. Please try again later."
                };
                
               await context.Response.WriteAsJsonAsync(response);
            }
        }
    }
}
