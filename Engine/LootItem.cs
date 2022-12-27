using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem (Item details, int dropPrcntg, bool isDefItem) 
        {
            Details = details;
            DropPercentage = dropPrcntg;
            IsDefaultItem = isDefItem;
        }
    }
}
