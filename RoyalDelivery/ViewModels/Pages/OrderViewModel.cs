using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models;
using RoyalDelivery.Repos.MemoryRepo;
using RoyalDelivery.ViewModels.Base;
using System.Collections.ObjectModel;

namespace RoyalDelivery.ViewModels.Pages
{
    public partial class OrderViewModel : ViewModelBase
    {
        private readonly OrdeMemoryRepo _repo;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private Order? selectedOrder;

        public ObservableCollection<Order> Orders { get; }

        public OrderViewModel()
        {
            
        }
        public OrderViewModel(OrdeMemoryRepo orderRepo)
        {
            _repo = orderRepo;
            // dummy data
            Orders = new ObservableCollection<Order>(_repo.GetAll());
        }


        [RelayCommand(CanExecute = nameof(CanDelete))]
        private void DeleteSelected()
        {
           if (SelectedOrder == null) return;
            _repo.Remove(SelectedOrder.Id);
            Orders.Remove(SelectedOrder);
            SelectedOrder = null;
        }

        private bool CanDelete()
        {
            return SelectedOrder != null;
        }
    }
}
