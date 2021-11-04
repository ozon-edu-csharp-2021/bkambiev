using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.AggregationModels.EmployeeAggregate;

namespace MerchandiseService.Domain.AggregationModels.MerchPackAggregate
{
    public interface IMerchPackRepository
    {
        Task<MerchPack> CreateAsync(int EmployeeId, MerchPack merchPack);
        Task<MerchPack> UpdateAsync(int EmployeeId, MerchPack merchPack);
        Task<MerchPack> FindByEmployeeAsync(int employeeId, CancellationToken token = default);
    }
}