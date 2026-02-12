using RoyalDelivery.Models;
using System;
using System.Diagnostics;

namespace RoyalDelivery.Repos
{
    /// <summary>
    /// Repo a rendelések tárolására
    /// </summary>
    public class OrderRepo
    {
        /// <summary>
        /// Memóriában tárolt tesztadatok
        /// </summary>
        private readonly List<Order> _items =
        [
            new Order {Id= 0, Name = "Pizza", Meals = [], },
            new Order {Id= 1,  Name = "Gyros", Meals = [], },
            new Order {Id= 2,  Name = "Hamburger", Meals = [], },
            new Order {Id= 3,  Name = "Sült csirke", Meals = [], },
            new Order {Id= 4,  Name = "Sült krumpli", Meals = [], },
            new Order {Id= 5,  Name = "Kóla", Meals = [], }
        ];

        /// <summary>
        /// Összes rendelés írható és olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(int id)
        {
            var index = _items.FindIndex(o => o.Id == id);
            if (index < 0) return;
            _items.RemoveAt(index);
        }
    }
}
