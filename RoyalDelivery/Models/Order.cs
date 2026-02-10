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
        private string _customerName;
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
        public string CustomerName
        {
            get => _customerName;
            set => _customerName = value;
        }
       
        public Order(List<Meal> meals, string customerName)
        {
            Id = _nextId++;
            _meals = meals ?? throw new ArgumentNullException(nameof(meals));
            _customerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
        }

        public Order()
        {
        }

        public override string ToString() {
            return $"A rendelés adatai: Id={Id}, Meals={string.Join(", ", Meals)}, CustomerName={CustomerName}";
        }
    }
}
