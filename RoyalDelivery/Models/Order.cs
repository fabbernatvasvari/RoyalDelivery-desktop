using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Models
{
    /// <summary>
    /// Rendelés.
    /// </summary>
    public class Order
    {
        private int _id;
        private List<Meal> _meals;
        private string _name;
        private static int _nextId = 1;
        public int Id
        {
            get => _id;
            private set => _id = value;
        }
        public List<Meal> Meals
        {
            get => _meals;
            set => _meals = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
       
        public Order(int id, List<Meal> meals, string customerName)
        {
            Id = id;
            _meals = meals ?? throw new ArgumentNullException(nameof(meals));
            _name = customerName ?? throw new ArgumentNullException(nameof(customerName));
        }

        public Order()
        {
        }

        public void OrderDate()
        {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return $"A rendelés adatai: Id={Id}, Meals={string.Join(", ", Meals)}, Username={Name}";
        }
    }
}
