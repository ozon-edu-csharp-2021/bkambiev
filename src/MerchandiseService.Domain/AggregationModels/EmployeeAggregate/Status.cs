using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.EmployeeAggregate
{
    public class Status : Entity
    {
        public StatusType Type { get; }

        public Status(StatusType type)
        {
            Type = type;
        }
    }
}