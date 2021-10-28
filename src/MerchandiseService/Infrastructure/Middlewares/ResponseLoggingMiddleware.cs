using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MerchandiseService.Infrastructure.Middlewares
{
    public class ResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public ResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            await LogResponseAsync(context);
            await _next(context);
        }

        private async Task LogResponseAsync(HttpContext context)
        {
            await Task.Run(() =>
            {
                try
                {
                    _logger.LogInformation("Response logged");
                    _logger.LogInformation($"route: {context.Request.Path}");
                    
                    if (context.Response.Headers.Count > 0)
                    {
                        if (context.Request.Headers["Content-Type"] == "application/grpc")
                        {
                            return;
                        }
                        _logger.LogInformation(JsonSerializer.Serialize(context.Response.Headers));
                    }
                    
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "Could not log response");
                    throw;
                }
            });
        }
    }
}