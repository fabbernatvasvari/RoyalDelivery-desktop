using RoyalDelivery.Models;

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
        private List<Order> _items = new()
        {
            new Order { Name = "Pizza", Meals = new List<Meal>(), },
            new Order { Name = "Gyros", Meals = new List<Meal>(), },
            new Order { Name = "Hamburger", Meals = new List<Meal>(), },
            new Order { Name = "Sült csirke", Meals = new List<Meal>(), },
            new Order { Name = "Sült krumpli", Meals = new List<Meal>(), },
            new Order { Name = "Kóla", Meals = new List<Meal>(), }
        };

        /// <summary>
        /// Összes rendelés írható és olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Order> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedOrder) meghívva.");
            

            _items.RemoveAt(selectedId);
            _items.RemoveAt(selectedId);
        }
    }
}
