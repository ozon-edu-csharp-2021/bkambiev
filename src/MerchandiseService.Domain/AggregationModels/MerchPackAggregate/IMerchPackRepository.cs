using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;

namespace MerchandiseService.Domain.AggregationModels.MerchPackAggregate
{
    public interface IMerchPackRepository
    {
        Task<MerchPack> CreateAsync(int EmployeeId, MerchPack merchPack, CancellationToken token = default);
        Task<MerchPack> FindByEmployeeAsync(int employeeId, CancellationToken token = default);
        Task<int> GetMerchPack(int employeeId, MerchType merchtype, CancellationToken token = default);
        Task<bool> HaveEmployeeMerchPack(int employeeId, MerchType merchType, CancellationToken token = default);
    }
}