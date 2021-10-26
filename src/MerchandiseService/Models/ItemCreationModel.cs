using System.Collections.Generic;

namespace MerchandiseService.Models
{
    public class ItemCreationModel
    {

        public string ItemName { get; set; }
        
        public ItemCreationModel(string itemName)
        {
            ItemName = itemName;
        }
    }
}