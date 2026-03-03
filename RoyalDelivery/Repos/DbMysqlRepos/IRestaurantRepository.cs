using RoyalDelivery.Models.DbMysqlModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos.DbMysqlRepos
{
    public class IRestaurantRepository
    {
        private readonly List<Restaurant> _items;

        public List<Restaurant> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedMeal) meghívva.");

            _items.RemoveAt(selectedId);
        }
        public void Add(Restaurant restaurant)
        {
            _items.Add(restaurant);
        }
    }
}
