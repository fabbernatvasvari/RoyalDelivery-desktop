using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RoyalDelivery.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        // ---------- Current View ----------
        [ObservableProperty]
        private object currentView;

        private readonly MealViewModel mealViewModel = new();
        private readonly RestaurantViewModel restaurantViewModel = new();

        [ObservableProperty]
        private Order selectedOrder;

        public ICommand ShowHomeCommand { get; }
        public ICommand ShowSettingsCommand { get; }

        [ObservableProperty]
        private string _currentPageTitle;


        // ---------- Navigation Commands ----------

        [RelayCommand]
        private void ShowMealView()
        {
            CurrentView = new MealViewModel();
        }

        [RelayCommand]
        private void ShowRestaurantView()
        {
            CurrentView = new RestaurantViewModel();
        }
        [RelayCommand]
        private void ShowUserView()
        {
            CurrentView = new UserViewModel();
        }

        [RelayCommand]
        private void ShowOrderView()
        {
            CurrentView = new OrderViewModel();
        }

        [RelayCommand]
        private void ShowControlPanelView()
        {
            CurrentView = new RestaurantViewModel();
        }

        [RelayCommand]
        private void ShowSettings()
        {
            CurrentView = new SettingsViewModel();
        }

        [RelayCommand]
        private void ShowHome()
        {
            CurrentView = new HomeViewModel();
        }



        // ---------- Constructor ----------
        public MainWindowViewModel()
        {
            

            // Alapértelmezett nézet: üres (csak menü látszik)
            CurrentView = null;
        }
    }
}
