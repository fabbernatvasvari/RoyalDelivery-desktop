using CommunityToolkit.Mvvm.ComponentModel;
using RoyalDelivery.Models;
using RoyalDelivery.Repos;
using System.Collections.ObjectModel;

namespace RoyalDelivery.ViewModels
{
    public partial class RestaurantViewModel : ObservableObject
    {
        private readonly RestaurantRepo _repo = new();

        [ObservableProperty]
        public ObservableCollection<Restaurant> restaurants;

        public RestaurantViewModel()
        {
            restaurants = new ObservableCollection<Restaurant>(_repo.GetAll());
        }

    }
}
