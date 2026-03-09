using RoyalDelivery.Models.DbMysqlModels;
using RoyalDelivery.Repos.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace RoyalDelivery.Repos.DbMysqlRepos
{
    public class MealDbRepo : IMealRepo
    {

        // private readonly List<Meal> _items;
        private readonly RoyaldeliveryDbContext _context;

        public MealDbRepo(RoyaldeliveryDbContext context)
        {
            _context = context;
        }
        public List<Meal> GetAll()
        {
            return _context.Meals.ToList();
        }

        /*public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedMeal) meghívva.");

            _items.RemoveAt(selectedId);
        }
        public void Add(Meal meal)
        {
            _items.Add(meal);
        }*/
    }
}
