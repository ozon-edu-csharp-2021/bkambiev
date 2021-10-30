namespace MerchandiseService.HttpModels
{
    public class ItemResponse
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public ItemResponse(long Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}