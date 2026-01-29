using MyApp.Desktop.Models;

namespace MyApp.Desktop.Repos
{
    /// <summary>
    /// Repo az iskolai osztályok tárolására
    /// </summary>
    public class SchoolClassRepo
    {
        /// <summary>
        /// Memóriában tárolt iskolai osztályok (tesztadatok)
        /// </summary>
        private List<SchoolClass> _items = new()
        {
            new SchoolClass(9,"a", 26),
            new SchoolClass(9,"b", 0),
            new SchoolClass(9,"c", 24)
        };

        /// <summary>
        /// Összes iskolai osztály csak olvasható listáját visszaadó metódus
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<SchoolClass> GetAll()
        {
            return _items.ToList();
        }
    }
}
