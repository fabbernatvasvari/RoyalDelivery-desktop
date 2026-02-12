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

        public Restaurant(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
            Menu =
            [
                new(0, "Pizza Margherita", 1500),
                new(1, "Gyros tál", 2000),
                new(2,"Hamburger", 1800),
                new(3,"Sült csirke", 2200),
                new(4,"Rántott sajt", 1700),
                new(5,"Lazac steak", 3000),
                new(6,"Vegetáriánus lasagne", 2500),
                new(7,"Sült zöldségek", 1200)
            ];
        }

        public Restaurant()
        {
        }

        public override string ToString() {
            return $"Az étterem adatai: Id={Id}, Username={Name}, Address={Address}";
        }
    }
}
