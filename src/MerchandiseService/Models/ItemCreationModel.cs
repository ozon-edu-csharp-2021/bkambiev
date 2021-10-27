using System.Collections.Generic;

namespace MerchandiseService.Models
{
    public class ItemCreationModel
    {

        public string Name { get; set; }
        
        public ItemCreationModel(string Name)
        {
            this.Name = Name;
        }
    }
}