using RoyalDelivery.Models.DbMysqlModels;
using RoyalDelivery.Models.MemoryModels;
using RoyalDelivery.Repos.Interface;
using System;
using System.Diagnostics;

namespace RoyalDelivery.Repos.MemoryRepo
{
    /// <summary>
    /// Repo a rendelések tárolására
    /// </summary>
    public class OrderMemoryRepo:IOrderRepo
    {
        /// <summary>
        /// Memóriában tárolt tesztadatok
        /// </summary>
        private readonly List<Order> _items =
        [
            new Order {Id= 0, RestaurantId = "Pizza", UserId = "1" },
            new Order {Id= 1,  RestaurantId = "Gyros", UserId = "1" },
            new Order {Id= 2,  RestaurantId = "Hamburger", UserId = "1" },
            new Order {Id= 3,  RestaurantId = "Sült csirke", UserId = "1" },
            new Order {Id= 4,  RestaurantId = "Sült krumpli", UserId = "1" },
            new Order {Id= 5,  RestaurantId = "Kóla", UserId = "1" }
        ];

        /// <summary>
        /// Összes rendelés írható és olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        List<Order> IOrderRepo.GetAll()
        {
            throw new NotImplementedException();
            //return _items.ToList();
        }


        public void Remove(int id)
        {
            var index = _items.FindIndex(o => o.Id == id);
            if (index < 0) return;
            _items.RemoveAt(index);
        }

        internal List<Order> GetAll()
        {
            return _items.ToList();
        }
    }
}
