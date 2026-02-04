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
            new Order(1,"A", 6),
            new Order(2,"B", 1),
            new Order(3,"C", 24)
        };

        /// <summary>
        /// Összes rendelés írható és olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        public List<Order> GetAll()
        {
            return _items.ToList();
        }

        internal void Remove(Order selectedOrder)
        {
            Console.WriteLine("internal void Remove(Order SelectedOrder) meghívva.");
            if (selectedOrder == null)
                return;

            _items.Remove(selectedOrder);
        }
    }
}
