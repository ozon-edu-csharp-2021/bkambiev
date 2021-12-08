using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchandiseService.Domain.AggregationModels.MerchPackAggregate;
using MerchandiseService.Infrastructure.Commands;

namespace MerchandiseService.Infrastructure.Handlers
{
    public class GetMerchPackHandler : IRequestHandler<GetMerchPackCommand, int>
    {
        private readonly IMerchPackRepository _merchPackRepository;

        public GetMerchPackHandler(IMerchPackRepository merchPackRepository)
        {
            _merchPackRepository = merchPackRepository;
        }

        public async Task<int> Handle(GetMerchPackCommand request, CancellationToken token)
        {
            bool haveMerchPack = await _merchPackRepository.HaveEmployeeMerchPack(request.MerchPackRequest.Employee.Id, request.MerchPackRequest.MerchPackType);
            int requestId = 0;
            if (!haveMerchPack)
            {
                requestId = await _merchPackRepository.GetMerchPack(request.MerchPackRequest.Employee.Id, request.MerchPackRequest.MerchPackType, token);
            }
            
            return requestId;
        }
    }
}