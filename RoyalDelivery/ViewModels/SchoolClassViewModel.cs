using CommunityToolkit.Mvvm.ComponentModel;
using MyApp.Desktop.Models;
using MyApp.Desktop.Repos;
using System.Collections.ObjectModel;

namespace MyApp.Desktop.ViewModels
{
    /// <summary>
    /// MainViewModel a View-n megjelenendő adatokat és interakciókat kezeli
    /// </summary>
    public partial class SchoolClassViewModel : ObservableObject
    {
        /// <summary>
        /// A ViewModel-nek része a repo, így eléri a repóban lévő adatokat
        /// </summary>
        private readonly SchoolClassRepo _repo = new SchoolClassRepo();

        /// <summary>
        /// Hogy a View-n megjelenjenek az iskolai osztályok, a ViewModel biztosít egy property-t
        /// </summary>
        public ObservableCollection<SchoolClass> Classes { get; }

        public SchoolClassViewModel()
        {
            // Az iskolai osztályok a repóból kerülnek betöltésre
            Classes = new ObservableCollection<SchoolClass>(_repo.GetAll());
        }
    }
}