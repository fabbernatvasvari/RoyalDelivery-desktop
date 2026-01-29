using RoyalDelivery.Models;

namespace RoyalDelivery.Repos
{
    /// <summary>
    /// Repo az iskolai osztályok tárolására
    /// </summary>
    public class OrderRepo
    {
        /// <summary>
        /// Memóriában tárolt iskolai osztályok (tesztadatok)
        /// </summary>
        private List<Order> _items = new()
        {
            new Order(9,"a", 26),
            new Order(9,"b", 0),
            new Order(9,"c", 24)
        };

        /// <summary>
        /// Összes iskolai osztály csak olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<Order> GetAll()
        {
            return _items.ToList();
        }
    }
}
