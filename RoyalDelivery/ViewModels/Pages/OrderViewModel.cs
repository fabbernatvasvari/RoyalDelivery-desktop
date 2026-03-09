using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models.MemoryModels;
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
        private OrderFake? selectedOrder;

        public ObservableCollection<OrderFake> Orders { get; }

        public OrderViewModel()
        {
            
        }
        public OrderViewModel(OrdeMemoryRepo orderRepo)
        {
            _repo = orderRepo;
            // dummy data
            Orders = new ObservableCollection<OrderFake>(_repo.GetAll());
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
