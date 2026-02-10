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
        new Order { Id = new Id(0), Name = "Pizza rendelés", OrderCount = 3 },
        new Order { Id = new Id(1), Name = "Gyros rendelés", OrderCount = 5 },
        new Order { Id = new Id(2), Name = "Hamburger rendelés", OrderCount = 2 },
    };

        /// <summary>
        /// Összes rendelés írható és olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(Id selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedOrder) meghívva.");
            if (selectedId == null)
                return;

            _items.RemoveAt(selectedId.Value);
            _items.RemoveAt(selectedId.Value);
        }
    }
}
