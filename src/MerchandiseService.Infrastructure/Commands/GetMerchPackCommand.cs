using MediatR;
using MerchandiseService.Domain.AggregationModels.EmployeeAggregate;
using MerchandiseService.Domain.AggregationModels.MerchPackAggregate;

namespace MerchandiseService.Infrastructure.Commands
{
    public class GetMerchPackCommand : IRequest<MerchPack>
    {
        public Employee Employee { get; }

        public GetMerchPackCommand(Employee employee)
        {
            Employee = employee;
        }
    }
}