using RoyalDelivery.Models.MemoryModels;
using System;
using System.Diagnostics;

namespace RoyalDelivery.Repos.MemoryRepo
{
    /// <summary>
    /// Repo a rendelések tárolására
    /// </summary>
    public class OrdeMemoryRepo
    {
        /// <summary>
        /// Memóriában tárolt tesztadatok
        /// </summary>
        private readonly List<OrderFake> _items =
        [
            new OrderFake {Id= 0, Name = "Pizza", Meals = [], },
            new OrderFake {Id= 1,  Name = "Gyros", Meals = [], },
            new OrderFake {Id= 2,  Name = "Hamburger", Meals = [], },
            new OrderFake {Id= 3,  Name = "Sült csirke", Meals = [], },
            new OrderFake {Id= 4,  Name = "Sült krumpli", Meals = [], },
            new OrderFake {Id= 5,  Name = "Kóla", Meals = [], }
        ];

        /// <summary>
        /// Összes rendelés írható és olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderFake> GetAll()
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
