using System;
using System.Linq;
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
            await LogResponse(context);
            await _next(context);
        }

        private async Task LogResponse(HttpContext context)
        {
            await Task.Run(() =>
            {
                try
                {
                    _logger.LogInformation("Response logged");
                    _logger.LogInformation($"route: {context.Request.Path}");
                    
                    if (context.Response.Headers.ContentLength > 0)
                    {
                        var headers = context.Response.Headers.ToDictionary(hKey => hKey.Key, hValue => hValue.Value);
                        
                        foreach (var header in headers)
                        {
                            _logger.LogInformation($"header: {header.Key} value: {header.Value}");
                        }
                    }
                    
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "Could not log response");
                }
            });
        }
    }
}