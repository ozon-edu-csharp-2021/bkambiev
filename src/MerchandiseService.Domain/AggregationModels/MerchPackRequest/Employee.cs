using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchPackRequest
{
    public class Employee : Entity
    {
        public Email Email { get; }

        public Employee(Email email)
        {
            Email = email;
        }
    }
}