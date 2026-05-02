using System;
using System.Collections.Generic;

namespace PantryManager
{
    public class ShoppingList
    {
        public int ListID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }

        // Association: A ShoppingList references one or more PantryItem entries
        public List<PantryItem> Items { get; set; }

        public ShoppingList()
        {
            Items = new List<PantryItem>();
            CreatedDate = DateTime.Now;
            Status = "Active";
        }

        public void AddEntry(PantryItem item)
        {
            Items.Add(item);
        }
    }
}