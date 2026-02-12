using RoyalDelivery.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos
{
    public class MealRepo
    {
        private List<Meal> _items = new()
        {
            new Meal(1, "Pizza Margherita", 1500),
            new Meal(2, "Gyros tál", 2000),
            new Meal(3,"Hamburger", 1800),
            new Meal(4,"Sült csirke", 2200),
            new Meal(5,"Rántott sajt", 1700),
            new Meal(6,"Lazac steak", 3000),
            new Meal(7,"Vegetáriánus lasagne", 2500),
            new Meal(8,"Sült zöldségek", 1200)
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
