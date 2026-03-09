using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Models.MemoryModels
{
    /// <summary>
    /// Rendelés.
    /// </summary>
    public class OrderFake
    {
        private int _id;
        private List<MealFake> _meals;
        private string _name;
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public List<MealFake> Meals
        {
            get => _meals;
            set => _meals = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
       
        public OrderFake(int id, List<MealFake> meals, string customerName)
        {
            Id = id;
            _meals = meals ?? throw new ArgumentNullException(nameof(meals));
            _name = customerName ?? throw new ArgumentNullException(nameof(customerName));
        }

        public OrderFake()
        {
        }

        public override string ToString() {
            return $"A rendelés adatai: Id={Id}, Meals={string.Join(", ", Meals)}, Username={Name}";
        }
    }
}
