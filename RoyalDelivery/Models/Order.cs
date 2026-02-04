namespace RoyalDelivery.Models
{
    /// <summary>
    /// Rendelés.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// A rendelés sürgőssége (pl. 9, 10, 11, 12).
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// A termékek minőség- és szállítási kategóriája (pl. A, B, C).
        /// </summary>
        public string Section { get; set; } = string.Empty;

        public string Name => $"{Grade}.{Section}";

        /// <summary>
        /// Az osztályban tanuló diákok száma.
        /// </summary>
        public int OrderCount { get; set; }
        
        // Üres konstruktor
        public Order()
        {
        }

        // Paraméteres konstruktor
        public Order(int grade, string section, int OrderCount)
        {
            Grade = grade;
            Section = section;
            OrderCount = OrderCount;
        }

        // Barátságos megjelenítés
        public override string ToString()
        { 
            return $"{Grade}.{Section} – {OrderCount} fő";
        }
    }
}
