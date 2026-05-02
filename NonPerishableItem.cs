using System;

namespace PantryManager
{
    public class NonPerishableItem : PantryItem
    {
        public int ShelfLifeDays { get; set; }
        public string StorageLocation { get; set; }

        public int GetShelfLife()
        {
            return ShelfLifeDays;
        }
    }
}