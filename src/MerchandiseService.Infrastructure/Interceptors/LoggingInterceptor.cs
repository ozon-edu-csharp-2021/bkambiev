using System.Text.Json;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Logging;

namespace MerchandiseService.Infrastructure.Interceptors
{
    public class LoggingInterceptor : Interceptor
    {
        private readonly ILogger<LoggingInterceptor> _logger;

        public LoggingInterceptor(ILogger<LoggingInterceptor> logger)
        {
            _logger = logger;
        }
        
        public async override Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request,
            ServerCallContext context,
            UnaryServerMethod<TRequest, TResponse> continuation)
        {
            var requestJson = JsonSerializer.Serialize(request);
            
            var response = await continuation(request, context);

            var responseJson = JsonSerializer.Serialize(response);
            _logger.LogInformation($"Grpc log. Request: {requestJson} Response: {responseJson}");
            return response;
        }
    }
}