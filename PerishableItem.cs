using System;

namespace PantryManager
{
    public class PerishableItem : PantryItem
    {
        public double StorageTemp { get; set; }
        public bool RequiresRefrigeration { get; set; }

        public void CheckRefrigeration()
        {
            if (RequiresRefrigeration && StorageTemp > 40.0)
            {
                Console.WriteLine($"Warning: {Name} needs to be refrigerated below 40 degrees!");
            }
        }
    }
}