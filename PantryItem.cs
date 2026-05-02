using System;

namespace PantryManager
{
    public class PantryItem
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }

        public bool IsExpired()
        {
            return DateTime.Now > ExpirationDate;
        }
    }
}