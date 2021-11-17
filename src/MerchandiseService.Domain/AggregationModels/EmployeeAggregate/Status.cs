using MerchandiseService.Domain.Models;
using System.Collections.Generic;

namespace MerchandiseService.Domain.AggregationModels.EmployeeAggregate
{
    public class Status : ValueObject
    {
        public StatusType Type { get; }

        public Status(StatusType type)
        {
            Type = type;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Type;
        }
    }
}