using System;

namespace PantryManager
{
    public class ExpirationAlert
    {
        public int AlertID { get; set; }
        public DateTime AlertDate { get; set; }
        public string Message { get; set; }

        // Associations: An alert is triggered by exactly one PantryItem and received by exactly one User
        public PantryItem TriggeringItem { get; set; }
        public User Recipient { get; set; }

        public void SendAlert()
        {
            Console.WriteLine($"Alert sent to {Recipient?.Name}: {Message}");
        }
    }
}