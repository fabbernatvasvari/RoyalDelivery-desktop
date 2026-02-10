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
        private Meal? selectedOrder;

        public ObservableCollection<Order> Orders { get; }

        public OrderViewModel()
        {
            Orders = new ObservableCollection<Order>(_repo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDelete))]
        private void DeleteSelected()
        {
            _repo.Remove(SelectedOrder.Id);
            Orders.RemoveAt(SelectedOrder.Id.Value);
            SelectedOrder = null;
        }

        private bool CanDelete()
        {
            return SelectedOrder != null;
        }
    }
}
