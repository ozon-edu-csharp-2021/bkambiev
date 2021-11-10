using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchItemAggregate
{
    public class MerchItem : Entity
    {
        public Sku Sku { get; }
        public string Name { get; }
        public ItemType ItemType { get; }
        public ClothingSize ClothingSize { get; }
        public string Tag { get; }

        public MerchItem(Sku sku, string name, ItemType itemType, ClothingSize clothingSize, string tag)
        {
            Sku = sku;
            Name = name;
            ItemType = itemType;
            ClothingSize = clothingSize;
            Tag = tag;
        }
    }
}