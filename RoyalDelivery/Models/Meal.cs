namespace RoyalDelivery.Models
{
    /// <summary>
    /// Étel.
    /// </summary>
    public class Meal
    {
        private int _id;
        private string _name = string.Empty;
        private int _price;

        public int Id
        {
            get => _id;
            private set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Price
        {
            get => _price;
            set => _price = value;
        }



        public Meal(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Meal()
        {
        }

        public override string ToString()
        {
            return $"A rendelés adatai: Id={Id}, Username={Name}, Price={Price}";
        }
    }
}
