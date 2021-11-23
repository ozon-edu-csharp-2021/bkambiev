using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;

namespace MerchandiseService.Domain.AggregationModels.MerchPackAggregate
{
    public interface IMerchPackRepository
    {
        Task<MerchPack> CreateAsync(int EmployeeId, MerchPack merchPack, CancellationToken token = default);
        Task<MerchPack> UpdateEmployeeMerchPackAsync(int EmployeeId, MerchPack merchPack, CancellationToken token = default);
        Task<bool> UpdateEmployeeStatus(int EmployeeId, int StatusTypeId, CancellationToken token = default);
        Task<MerchPack> FindByEmployeeAsync(int employeeId, CancellationToken token = default);
        Task<int> GetMerchPack(int employeeId, int merchType, CancellationToken token = default);
    }
}