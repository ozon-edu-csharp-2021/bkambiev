using MediatR;
using MerchandiseService.Domain.AggregationModels.MerchPackAggregate;
using MerchandiseService.Infrastructure.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace MerchandiseService.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceCollection(this IServiceCollection service)
        {
            service.AddMediatR(typeof(EmployeeMerchPackInfoHander).Assembly);
            service.AddSingleton<IMerchPackRepository, MerchPackRepository>();
            return service;
        }
    }
}