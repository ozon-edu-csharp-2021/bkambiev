namespace MerchandiseService.HttpModels
{
    public class ItemResponse
    {
        public long ItemId { get; set; }

        public string ItemName { get; set; }

        public ItemResponse(long itemId, string itemName)
        {
            ItemId = itemId;
            ItemName = itemName;
        }
    }
}