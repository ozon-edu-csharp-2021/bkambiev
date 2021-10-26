using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Services.Interfaces;

namespace MerchandiseService.Services
{
   
    public class MerchandiseBusinessService : IMerchandiseBusinessService 
    {
        public Task<MerchType> GetEmployeeMerchInfo(long employeeId, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> GetMerch(long employeeId, long merchType, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }
    }
}