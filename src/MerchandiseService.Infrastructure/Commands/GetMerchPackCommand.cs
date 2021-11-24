using MediatR;
using MerchandiseService.Domain.AggregationModels.MerchPackRequest;

namespace MerchandiseService.Infrastructure.Commands
{
    public class GetMerchPackCommand : IRequest<int>
    {
        public MerchPackRequest MerchPackRequest { get; }

        public GetMerchPackCommand(MerchPackRequest merchPackRequest)
        {
            MerchPackRequest = merchPackRequest;
        }
    }
}