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
            
        };

        /// <summary>
        /// Összes rendelés írható és olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        public List<Order> GetAll()
        {
            return _items.ToList();
        }

        internal void Remove(Id selectedId) // TODO Id selectedId
        {
            Console.WriteLine("internal void Remove(Meal SelectedOrder) meghívva.");
            if (selectedId == null)
                return;

            _items.RemoveAt(selectedId.Value);
        }
    }
}
