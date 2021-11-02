using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            await LogRequestAsync(context);
            await _next(context);
        }

        private async Task LogRequestAsync(HttpContext context)
        {
            await Task.Run(() =>
            {
                try
                {
                    if ((context.Request.Headers.Count > 0) && (context.Request.ContentType.Contains("application/grpc")))
                    {
                        _logger.LogInformation($"Request logged. Route: {context.Request.Path} Headers: {JsonSerializer.Serialize(context.Request.Headers)}");
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(0, e, "Could not log request");
                    throw;
                }
            });
        }
    }
}