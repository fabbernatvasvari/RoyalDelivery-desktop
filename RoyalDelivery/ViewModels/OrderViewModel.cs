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
            // dummy data
            Orders = new ObservableCollection<Order>()
            {
                new Order { CustomerName = "Pizza", Meals = new List<Meal>(), /* Id and OrderCount cannot be set here */ },
                new Order { CustomerName = "Gyros", Meals = new List<Meal>(), },
                new Order { CustomerName = "Hamburger", Meals = new List<Meal>(), },
                new Order { CustomerName = "Sült csirke", Meals = new List<Meal>(), },
                new Order { CustomerName = "Sült krumpli", Meals = new List<Meal>(), },
                new Order { CustomerName = "Kóla", Meals = new List<Meal>(), },
            };
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

        public ObservableCollection<User> Users { get; }
    }
}
