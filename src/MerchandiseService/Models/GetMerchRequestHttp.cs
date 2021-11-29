using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.AggregationModels.MerchPackAggregate;
using MerchandiseService.Domain.AggregationModels.MerchPackRequest;

namespace MerchandiseService.Models
{
    public class GetMerchRequestHttp
    {
        public int EmployeeId { get; }
        public int MerchTypeId { get; }
        public int StatusTypeId { get; }

        public GetMerchRequestHttp(int employeeId, int merchTypeId, int statusTypeId)
        {
            EmployeeId = employeeId;
            MerchTypeId = merchTypeId;
            StatusTypeId = statusTypeId;
        }
    }
}
