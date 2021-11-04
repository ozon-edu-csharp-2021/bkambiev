using CSharpCourse.Core.Lib.Enums;
using MediatR;
using MerchandiseService.Domain.AggregationModels.EmployeeAggregate;

namespace MerchandiseService.Infrastructure.Commands
{
    public class EmployeeMerchPackInfoCommand : IRequest<MerchType> 
    {
        public int EmployeeId { get; }

        public EmployeeMerchPackInfoCommand(int employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}