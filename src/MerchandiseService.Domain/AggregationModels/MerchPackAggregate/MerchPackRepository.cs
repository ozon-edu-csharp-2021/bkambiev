using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MerchandiseService.Domain.AggregationModels.MerchPackAggregate
{
    public class MerchPackRepository : IMerchPackRepository
    {

        Task<MerchPack> IMerchPackRepository.CreateAsync(int EmployeeId, MerchPack merchPack, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task<MerchPack> IMerchPackRepository.FindByEmployeeAsync(int employeeId, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task<int> IMerchPackRepository.GetMerchPack(int employeeId, int merchType, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task<MerchPack> IMerchPackRepository.UpdateEmployeeMerchPackAsync(int EmployeeId, MerchPack merchPack, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task<bool> IMerchPackRepository.UpdateEmployeeStatus(int EmployeeId, int StatusTypeId, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
