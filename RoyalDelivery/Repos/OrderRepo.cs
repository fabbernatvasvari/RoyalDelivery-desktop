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
            new Order { CustomerName = "Pizza rendelés", Meals = new List<Meal>(), /* Id and OrderCount cannot be set here */ },
            new Order { CustomerName = "Gyros rendelés", Meals = new List<Meal>(), },
            new Order { CustomerName = "Hamburger rendelés", Meals = new List<Meal>(), },
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
