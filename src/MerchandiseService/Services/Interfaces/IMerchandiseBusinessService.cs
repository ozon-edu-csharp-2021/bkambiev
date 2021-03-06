using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;

namespace MerchandiseService.Services.Interfaces
{
    public interface IMerchandiseBusinessService
    {
        Task<MerchType> GetEmployeeMerchInfoAsync(long employeeId, CancellationToken token);

        Task<bool> GetMerchAsync(long employeeId, long merchType, CancellationToken token);
    }
}