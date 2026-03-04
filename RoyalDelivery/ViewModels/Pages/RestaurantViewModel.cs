using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models;
using RoyalDelivery.Repos;
using RoyalDelivery.ViewModels.Base;
using System.Collections.ObjectModel;

namespace RoyalDelivery.ViewModels
{
    public partial class RestaurantViewModel : ViewModelBase
    {
        private readonly RestaurantRepo _repo;


        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private Restaurant? selectedRestaurant;


        [ObservableProperty]
        public ObservableCollection<Restaurant> restaurants;

        public RestaurantViewModel(RestaurantRepo restaurantRepo)
        {
            _repo = restaurantRepo;
            restaurants = new ObservableCollection<Restaurant>(_repo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDelete))]
        private void DeleteSelected()
        {
            if (SelectedRestaurant == null) return;
            _repo.Remove(SelectedRestaurant.Id);
            Restaurants.Remove(SelectedRestaurant);
            SelectedRestaurant = null;
        }

        private bool CanDelete()
        {
            return SelectedRestaurant != null;
        }
    }
}
