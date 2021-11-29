using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchandiseService.GrpcServices;
using MerchandiseService.Infrastructure.Extensions;
using MerchandiseService.Infrastructure.Interceptors;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace MerchandiseService
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServiceCollection();
            
            services.AddControllers();
            services.AddGrpc(options => options.Interceptors.Add<LoggingInterceptor>());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<MerchandiseGrpService>();
                endpoints.MapControllers();
            });
        }
    }
}