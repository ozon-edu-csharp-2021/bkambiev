using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Services.Interfaces;

namespace MerchandiseService.Services
{
   
    public class MerchandiseBusinessService : IMerchandiseBusinessService 
    {
        public Task<MerchType> GetEmployeeMerchInfoAsync(long employeeId, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> GetMerchAsync(long employeeId, long merchType, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }
    }
}