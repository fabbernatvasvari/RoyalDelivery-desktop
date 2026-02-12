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
            new Restaurant
            {
                Id = 0,
                Name = "Royal Diner",
                Address = "123 Crown St."
            },
            new Restaurant
            {
                Id = 1,
                Name = "Palace Pizzeria",
                Address = "45 Marble Ave."
                
            },
            new Restaurant
            {
                Id = 2,
                Name = "Sovereign Sushi",
                Address = "9 Ocean Blvd."
            }
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

        public void Add(Restaurant restaurant)
        {
            _items.Add(restaurant);
        }
    }
}
