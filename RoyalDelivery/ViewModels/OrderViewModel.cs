using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models;
using RoyalDelivery.Repos;
using System.Collections.ObjectModel;

namespace RoyalDelivery.ViewModels
{
    public partial class OrderViewModel : ObservableObject
    {
        private readonly OrderRepo _repo = new();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private Order? selectedOrder;

        public ObservableCollection<Order> Orders { get; }

        public OrderViewModel()
        {
            // dummy data
            Orders = new ObservableCollection<Order>(_repo.GetAll());
        }


        [RelayCommand(CanExecute = nameof(CanDelete))]
        private void DeleteSelected()
        {
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
