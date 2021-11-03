using System.Collections.Generic;
using MerchandiseService.Domain.AggregationModels.MerchItemAggregate;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchPackAggregate
{
    public class MerchPack : Entity
    {
        public List<MerchItem> Pack { get; }

        public MerchPack(List<MerchItem> pack)
        {
            Pack = pack;
        }
    }
}