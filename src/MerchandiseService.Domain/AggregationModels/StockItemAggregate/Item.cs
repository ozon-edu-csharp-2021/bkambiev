using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.StockItemAggregate
{
    public class Item : Entity
    {
        public ItemType Type { get; }

        public Item(ItemType type)
        {
            Type = type;
        }
    }
}