using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;
using MediatR;
using MerchandiseService.Domain.AggregationModels.MerchPackAggregate;
using MerchandiseService.Infrastructure.Commands;

namespace MerchandiseService.Infrastructure.Handlers
{
    public class EmployeeMerchPackInfoHander : IRequestHandler<EmployeeMerchPackInfoCommand, MerchType>
    {
        private readonly IMerchPackRepository _merchPackRepository;

        public EmployeeMerchPackInfoHander(IMerchPackRepository merchPackRepository)
        {
            _merchPackRepository = merchPackRepository;
        }

        public async Task<MerchType> Handle(EmployeeMerchPackInfoCommand request, CancellationToken token)
        {
            MerchPack merchPack = await _merchPackRepository.FindByEmployeeAsync(request.EmployeeId, token);
            if (merchPack is null)
            {
                throw new Exception($"Not found merchpack for {request.EmployeeId}");
            }
            else
            {
                return merchPack.Type;
            }
        }
    }
}