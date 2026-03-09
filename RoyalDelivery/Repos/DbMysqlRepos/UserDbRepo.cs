using RoyalDelivery.Models.DbMysqlModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos.DbMysqlRepos
{
    public class UserDbRepo
    {
        private readonly List<User> _items;

        public List<User> GetAll()
        {
            return _items.ToList();
        }

        public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Meal SelectedMeal) meghívva.");

            _items.RemoveAt(selectedId);
        }
        public void Add(User user)
        {
            _items.Add(user);
        }
    }
}
