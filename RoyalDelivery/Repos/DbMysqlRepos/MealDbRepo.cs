using RoyalDelivery.Models.DbMysqlModels;
using System;
using System.Collections.Generic;
using System.Text;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace RoyalDelivery.Repos.DbMysqlRepos
{
    public class MealDbRepo
    {

        private readonly List<Meal> _items;

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
