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
            new Meal("Pizza Margherita", 1500),
            new Meal("Gyros tál", 2000),
            new Meal("Hamburger", 1800),
            new Meal("Sült csirke", 2200),
            new Meal("Rántott sajt", 1700),
            new Meal("Lazac steak", 3000),
            new Meal("Vegetáriánus lasagne", 2500),
            new Meal("Sült zöldségek", 1200)
        };

        public List<Meal> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(Id selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedMeal) meghívva.");
            if (selectedId == null)
                return;
            _items.RemoveAt(selectedId.Value);
        }
        public void Add(Meal meal)
        {
            _items.Add(meal);
        }
    }
}
