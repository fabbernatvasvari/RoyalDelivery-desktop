using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models;
using RoyalDelivery.ViewModels.Base;
using RoyalDelivery.ViewModels.Pages;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RoyalDelivery.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        // ---------- Current View ----------
        [ObservableProperty]
        private object currentView;

        private readonly MealViewModel _mealViewModel;
        private readonly RestaurantViewModel _restaurantViewModel;
        private readonly OrderViewModel _orderViewModel;
        private readonly UserViewModel _userViewModel;
        private readonly SettingsViewModel _settingsViewModel;
        private readonly HomeViewModel _homeViewModel;


        [ObservableProperty]
        private Order selectedOrder = new Order();



        [ObservableProperty]
        private string _currentPageTitle=string.Empty;


        // ---------- Navigation Commands ----------

        [RelayCommand]
        private void ShowMealView()
        {
            CurrentView = _mealViewModel;
        }

        [RelayCommand]
        private void ShowRestaurantView()
        {
            CurrentView = _restaurantViewModel;
        }
        [RelayCommand]
        private void ShowUserView()
        {
            CurrentView = _userViewModel;
        }

        [RelayCommand]
        private void ShowOrderView()
        {
            CurrentView = _orderViewModel;
        }

       /* [RelayCommand]
        private void ShowControlPanelView()
        {
            CurrentView = 
        }*/

        [RelayCommand]
        private void ShowSettings()
        {
            CurrentView = _settingsViewModel;
        }

        [RelayCommand]
        private void ShowHome()
        {
            CurrentView = _homeViewModel;
        }



        // ---------- Constructor ----------
        public MainWindowViewModel(
            MealViewModel mealViewModel,
            RestaurantViewModel restaurantViewModel,
            OrderViewModel orderViewModel,
            UserViewModel userViewModel,
            SettingsViewModel settingsViewModel,
            HomeViewModel homeViewModel)
        {
            _mealViewModel = mealViewModel;
            _restaurantViewModel = restaurantViewModel;
            _orderViewModel = orderViewModel;
            _userViewModel = userViewModel;
            _settingsViewModel = settingsViewModel;
            _homeViewModel = homeViewModel;

            CurrentView = _homeViewModel;
        }
    }
}
