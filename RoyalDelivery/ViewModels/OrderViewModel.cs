using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models;
using RoyalDelivery.Repos;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.Windows.Input;

namespace RoyalDelivery.ViewModels
{
    /// <summary>
    /// MainViewModel a View-n megjelenendő adatokat és interakciókat kezeli
    /// </summary>
    public partial class OrderViewModel : ObservableObject
    {
        /// <summary>
        /// A ViewModel-nek része a repo, így eléri a repóban lévő adatokat
        /// </summary>
        private readonly OrderRepo _repo = new OrderRepo();
        private Order selectedOrder;
        /// <summary>
        /// Hogy a View-n megjelenjenek az iskolai osztályok, a ViewModel biztosít egy property-t
        /// </summary>
        public ObservableCollection<Order> Classes { get; }

        public OrderViewModel()
        {
            // Az iskolai osztályok a repóból kerülnek betöltésre
            Classes = new ObservableCollection<Order>(_repo.GetAll());
        }

        private RelayCommand deleteSelectedCommand;
        public ICommand DeleteSelectedCommand => deleteSelectedCommand ??= new RelayCommand(DeleteSelected);

        private void DeleteSelected()
        {
            if (selectedOrder is null) return;

            _repo.Remove(selectedOrder);
            Classes.Remove(selectedOrder);
            selectedOrder = null;
        }

    }
}