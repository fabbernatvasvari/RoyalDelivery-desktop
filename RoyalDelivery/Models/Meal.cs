namespace RoyalDelivery.Models
{
    /// <summary>
    /// Étel.
    /// </summary>
    public class Meal
    {
        private Id _id;
        private string _name = string.Empty;
        private double _price;
        public static Id NextId = new Id(1);

        public Id Id
        {
            get => _id;
            private set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public Meal(string name, double price, Id _nextId)
        {
            Id = new Id(_nextId.Value++);
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"A rendelés adatai: Id={Id}, Name={Name}, Price={Price}";
        }
    }
}
