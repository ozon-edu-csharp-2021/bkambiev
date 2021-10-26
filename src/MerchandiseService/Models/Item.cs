using System.Collections.Generic;

namespace MerchandiseService.Models
{
    public class Item
    {
        public long ItemId { get; }

        public string ItemName { get; }

        public Item(long itemId, string itemName)
        {
            ItemId = itemId;
            ItemName = itemName;
        }
    }
}