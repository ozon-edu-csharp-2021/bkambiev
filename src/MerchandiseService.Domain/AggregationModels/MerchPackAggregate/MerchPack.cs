using System.Collections.Generic;
using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.AggregationModels.MerchItemAggregate;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchPackAggregate
{
    public class MerchPack : Entity
    {
        public List<MerchItem> Pack { get; }

        public MerchType Type { get; }

        public StatusType StatusType { get; }

        public MerchPack(List<MerchItem> pack, MerchType type, StatusType statusType)
        {
            Pack = pack;
            Type = type;
            StatusType = statusType;
        }
    }
}