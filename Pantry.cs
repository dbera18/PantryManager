using System;
using System.Collections.Generic;

namespace PantryManager
{
    public class Pantry
    {
        public int PantryID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        // Composition: A Pantry contains one or more PantryItem objects
        public List<PantryItem> Items { get; set; }

        public Pantry()
        {
            Items = new List<PantryItem>();
        }

        public void AddItem(PantryItem item)
        {
            Items.Add(item);
        }
    }
}