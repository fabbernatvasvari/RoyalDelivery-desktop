
using RoyalDelivery.Models.DbMysqlModels;
using System.Xml.Linq;

namespace RoyalDelivery.Repos.MemoryRepo
{
    public class MealMemoryRepo
    {
        private List<Meal> _items = new()
        {
            new Meal{Id = 1,  Name = "Pizza Margherita",Price= 1500},
            new Meal{Id = 2, Name =  "Gyros tál", Price=2000},
            new Meal{Id = 3, Name = "Hamburger",Price= 1800},
            new Meal{Id = 4, Name = "Sült csirke", Price=2200},
            new Meal{Id = 5, Name = "Rántott sajt",Price= 1700},
            new Meal{Id = 6, Name = "Lazac steak",Price= 3000},
            new Meal{Id = 7, Name = "Vegetáriánus lasagne", Price=2500},
            new Meal{Id = 8, Name = "Sült zöldségek", Price=1200}
        };

        public List<Meal> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedMeal) meghívva.");
            
            _items.RemoveAt(selectedId);
        }
        public void Add(Meal meal)
        {
            _items.Add(meal);
        }
    }
}
