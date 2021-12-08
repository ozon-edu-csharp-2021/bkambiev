using CSharpCourse.Core.Lib.Enums;
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

        Task<MerchPack> IMerchPackRepository.CreateAsync(int EmployeeId, MerchPack merchPack, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        Task<MerchPack> IMerchPackRepository.FindByEmployeeAsync(int employeeId, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        Task<int> IMerchPackRepository.GetMerchPack(int employeeId, MerchType merchtype, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        Task<bool> IMerchPackRepository.HaveEmployeeMerchPack(int employeeId, MerchType merchtype, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
    }
}
