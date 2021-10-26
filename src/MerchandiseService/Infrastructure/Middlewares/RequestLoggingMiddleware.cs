using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace MerchandiseService.Infrastructure.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await LogRequest(context);
            await _next(context);
        }

        private async Task LogRequest(HttpContext context)
        {
            await Task.Run(() =>
            {
                try
                {
                    _logger.LogInformation("Request logged");
                    _logger.LogInformation($"route: {context.Request.Path}");
                    
                    if (context.Request.Headers.ContentLength > 0)
                    {
                        var headers = context.Request.Headers.ToDictionary(hKey => hKey.Key, hValue => hValue.Value);
                        
                        foreach (var header in headers)
                        {
                            _logger.LogInformation($"header: {header.Key} value: {header.Value}");
                        }
                    }
                    
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "Could not log request");
                }
            });
        }
    }
}