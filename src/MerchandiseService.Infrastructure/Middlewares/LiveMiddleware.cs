using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MerchandiseService.Infrastructure.Middlewares
{
    public class LiveMiddleware
    {
        public LiveMiddleware(RequestDelegate next)
        {
            
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            await Task.FromResult(context.Response.StatusCode = StatusCodes.Status200OK);
        }
    }
}