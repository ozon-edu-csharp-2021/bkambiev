using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchandiseService.Domain.AggregationModels.MerchPackAggregate;
using MerchandiseService.Infrastructure.Commands;

namespace MerchandiseService.Infrastructure.Handlers
{
    public class GetMerchPackHandler : IRequestHandler<GetMerchPackCommand, MerchPack>
    {
        private readonly IMerchPackRepository _merchPackRepository;

        public GetMerchPackHandler(IMerchPackRepository merchPackRepository)
        {
            _merchPackRepository = merchPackRepository;
        }

        public Task<MerchPack> Handle(GetMerchPackCommand request, CancellationToken cancellationToken)
        {
            
            throw new System.NotImplementedException();
        }
    }
}