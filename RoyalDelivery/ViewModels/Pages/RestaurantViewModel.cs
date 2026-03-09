using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models.DbMysqlModels;
using RoyalDelivery.Repos.Interface;
using RoyalDelivery.ViewModels.Base;
using System.Collections.ObjectModel;

namespace RoyalDelivery.ViewModels.Pages
{
    public partial class RestaurantViewModel : ViewModelBase
    {
        private readonly IRestaurantRepo _repo;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private Restaurant? selectedRestaurant;


        [ObservableProperty]
        public ObservableCollection<Restaurant> restaurants;

        public RestaurantViewModel()
        {
        }

        public RestaurantViewModel(IRestaurantRepo restaurantRepo)
        {
            _repo = restaurantRepo;
            restaurants = new ObservableCollection<Restaurant>(_repo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDelete))]
        private void DeleteSelected()
        {
            //if (SelectedRestaurant == null) return;
            //_repo.Remove(SelectedRestaurant.Id);
            //Restaurants.Remove(SelectedRestaurant);
            //SelectedRestaurant = null;
        }

        private bool CanDelete()
        {
            return SelectedRestaurant != null;
        }
    }
}
