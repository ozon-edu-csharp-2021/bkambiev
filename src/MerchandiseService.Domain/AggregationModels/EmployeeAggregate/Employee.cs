using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.EmployeeAggregate
{
    public class Employee : Entity
    {
        public Email Email { get; }
        public Status Status { get; }

        public Employee(Email email, Status status)
        {
            Email = email;
            Status = status;
        }
    }
}