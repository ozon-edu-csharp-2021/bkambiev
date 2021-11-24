using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.AggregationModels.MerchPackAggregate;
using MerchandiseService.Domain.AggregationModels.MerchPackRequest;

namespace MerchandiseService.Models
{
    public class GetMerchRequestHttp
    {
        public Employee Employee { get; }
        public MerchType MerchType { get; }
        public Email Email { get; }
        public StatusType StatusType { get; }

        public GetMerchRequestHttp(Employee employee, MerchType merchType, Email email, StatusType statusType)
        {
            Employee = employee;
            MerchType = merchType;
            Email = email;
            StatusType = statusType;
        }
    }
}
