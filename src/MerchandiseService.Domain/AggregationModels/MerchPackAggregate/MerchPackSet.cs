using System;
using System.Collections.Generic;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchPackAggregate
{
    public class MerchPackSet : ValueObject
    {
        public HashSet<Sku> Value { get; }

        public MerchPackSet(HashSet<Sku> value)
        {
            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is MerchPackSet set)
            {
                return Value.SetEquals(set.Value);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Value);
        }
    }
}