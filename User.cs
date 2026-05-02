using System;
using System.Collections.Generic;

namespace PantryManager
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Association: A user manages Pantries, creates ShoppingLists, and receives ExpirationAlerts
        public List<Pantry> Pantries { get; set; }
        public List<ShoppingList> ShoppingLists { get; set; }
        public List<ExpirationAlert> Alerts { get; set; }

        public User()
        {
            // Initialize the lists in the constructor to avoid null reference errors
            Pantries = new List<Pantry>();
            ShoppingLists = new List<ShoppingList>();
            Alerts = new List<ExpirationAlert>();
        }

        public bool Login()
        {
            // Simple placeholder for login logic
            Console.WriteLine($"{Name} has logged into the system.");
            return true;
        }
    }
}