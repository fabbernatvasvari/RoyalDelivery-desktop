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
         public void Remove(int selectedId)
        {
            Console.WriteLine("public void Remove(Restaurant SelectedRestaurant) meghívva.");
            
            _items.RemoveAt(selectedId);
        }

        public void Add(Restaurant restaurant)
        {
            _items.Add(restaurant);
        }
    }
}
