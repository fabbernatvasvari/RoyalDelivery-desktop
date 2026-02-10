using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Models
{
    /// <summary>
    /// Étterem.
    /// </summary>
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Meal> Menu { get; set; }

        public Restaurant(string name, string address, List<Meal> menu)
        {
            Name = name;
            Address = address;
            Menu = menu;
        }

        public override string ToString() {
            return $"Az étterem adatai: Id={Id}, Name={Name}, Address={Address}, Menu={string.Join(", ", Menu)}";
        }
    }
}
