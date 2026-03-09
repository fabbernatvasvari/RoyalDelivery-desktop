using Microsoft.EntityFrameworkCore;
using RoyalDelivery.Models.DbMysqlModels;
using RoyalDelivery.Repos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos.DbMysqlRepos
{
    public class RestaurantDbRepo : IRestaurantRepo
    {
        // private readonly List<Restaurant> _items;
        private readonly RoyaldeliveryDbContext _context;

        public RestaurantDbRepo(RoyaldeliveryDbContext context)
        {
            _context = context;
        }

        public List<Restaurant> GetAll()
        {
            return _context.Restaurants.ToList();
        }

        /*public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedMeal) meghívva.");

            _items.RemoveAt(selectedId);
        }
        public void Add(Restaurant restaurant)
        {
            _items.Add(restaurant);
        }*/
    }
}
