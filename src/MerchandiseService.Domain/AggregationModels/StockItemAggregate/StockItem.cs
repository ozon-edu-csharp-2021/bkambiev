using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.StockItemAggregate
{
    public class StockItem : Entity
    {
        public Sku Sku { get; }
        public Name Name { get; }
        public Item ItemType { get; }
        public ClothingSize ClothingSize { get; }
        public Tag Tag { get; }

        public StockItem(Sku sku, Name name, Item itemType, ClothingSize clothingSize, Tag tag)
        {
            Sku = sku;
            Name = name;
            ItemType = itemType;
            ClothingSize = clothingSize;
            Tag = tag;
        }
    }
}