using MediatR;
using MerchandiseService.Domain.AggregationModels.EmployeeAggregate;
using MerchandiseService.Domain.AggregationModels.MerchPackAggregate;

namespace MerchandiseService.Infrastructure.Commands
{
    public class GetMerchPackCommand : IRequest<int>
    {
        public int EmployeeId { get; }

        public int MerchTypeId { get; }
        public GetMerchPackCommand(int employeeId, int merchTypeId)
        {
            EmployeeId = employeeId;
            MerchTypeId = merchTypeId;
        }
    }
}