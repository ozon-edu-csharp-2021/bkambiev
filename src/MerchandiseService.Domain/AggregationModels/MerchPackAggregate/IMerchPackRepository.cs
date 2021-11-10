using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.AggregationModels.EmployeeAggregate;

namespace MerchandiseService.Domain.AggregationModels.MerchPackAggregate
{
    public interface IMerchPackRepository
    {
        Task<MerchPack> CreateAsync(int EmployeeId, MerchPack merchPack);
        Task<MerchPack> UpdateEmployeeMerachPackAsync(int EmployeeId, MerchPack merchPack);
        Task UpdateEmployeeStatus(int EmployeeId, int StatusTypeId);
        Task<MerchPack> FindByEmployeeAsync(int employeeId, CancellationToken token = default);
    }
}