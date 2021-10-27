using System.Collections.Generic;

namespace MerchandiseService.Models
{
    public class Item
    {
        public long Id { get; }

        public string Name { get; }

        public Item(long Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}