namespace RoyalDelivery.Models.MemoryModels
{
    /// <summary>
    /// Étel.
    /// </summary>
    public class MealFake
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



        public MealFake(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public MealFake()
        {
        }

        public override string ToString()
        {
            return $"Az étel adatai: Id={Id}, Username={Name}, Price={Price}";
        }
    }
}
