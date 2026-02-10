using RoyalDelivery.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Repos
{
    public class RestaurantRepo
    {
        private List<Restaurant> _items = new()
        {

        };

        public List<Restaurant> GetAll()
        {
            return _items.ToList();
        }
         public void Remove(Id selectedId)
        {
            Console.WriteLine("public void Remove(Restaurant SelectedRestaurant) meghívva.");
            if (selectedId == null)
                return;
            _items.RemoveAt(selectedId.Value);
        }
    }
}
