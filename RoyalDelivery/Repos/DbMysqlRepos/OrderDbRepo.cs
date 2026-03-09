using RoyalDelivery.Models.DbMysqlModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos.DbMysqlRepos
{
    public class OrderDbRepo
    {
        private readonly List<Order> _items;
        private readonly RoyaldeliveryDbContext _context;

        public List<Order> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedMeal) meghívva.");

            _items.RemoveAt(selectedId);
        }
        public void Add(Order order)
        {
            _items.Add(order);
        }
    }
}
