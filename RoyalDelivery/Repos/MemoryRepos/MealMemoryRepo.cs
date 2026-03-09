using RoyalDelivery.Models.MemoryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos.MemoryRepo
{
    public class MealMemoryRepo
    {
        private List<MealFake> _items = new()
        {
            new MealFake(1, "Pizza Margherita", 1500),
            new MealFake(2, "Gyros tál", 2000),
            new MealFake(3,"Hamburger", 1800),
            new MealFake(4,"Sült csirke", 2200),
            new MealFake(5,"Rántott sajt", 1700),
            new MealFake(6,"Lazac steak", 3000),
            new MealFake(7,"Vegetáriánus lasagne", 2500),
            new MealFake(8,"Sült zöldségek", 1200)
        };

        public List<MealFake> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedMeal) meghívva.");
            
            _items.RemoveAt(selectedId);
        }
        public void Add(MealFake meal)
        {
            _items.Add(meal);
        }
    }
}
