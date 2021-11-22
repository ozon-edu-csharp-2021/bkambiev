using MerchandiseService.Domain.Models;
using System.Collections.Generic;

namespace MerchandiseService.Domain.AggregationModels.MerchItemAggregate
{
    public class MerchItem : ValueObject
    {
        public Sku Sku { get; }
        public string Name { get; }
        public ClothingSize ClothingSize { get; }
        public string Tag { get; }

        public MerchItem(Sku sku, string name, ClothingSize clothingSize, string tag)
        {
            Sku = sku;
            Name = name;
            ClothingSize = clothingSize;
            Tag = tag;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Sku;
            yield return Name;
            yield return ClothingSize;
            yield return Tag;
        }
    }
}