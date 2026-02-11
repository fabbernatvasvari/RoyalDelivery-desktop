using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RoyalDelivery.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        // ---------- Current View ----------
        [ObservableProperty]
        private object currentView;

        // ---------- Orders ----------
        [ObservableProperty]
        private ObservableCollection<string> orders;

        [ObservableProperty]
        private string selectedOrder;

        // ---------- Menu Items ----------
        [ObservableProperty]
        private ObservableCollection<string> menuItems = new ObservableCollection<string>()
        {
            "Pizza Margherita",
            "Gyros tál",
            "Hamburger menü"
        };

        // ---------- Commands ----------
        [RelayCommand]
        private void AddOrder()
        {
            Orders.Add($"Rendelés #{Orders.Count + 1}");
        }

        // ---------- Navigation Commands ----------
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

        // ---------- Constructor ----------
        public MainWindowViewModel()
        {
            // Orders inicializálása
            Orders = new ObservableCollection<string>()
            {
                "Rendelés #101",
                "Rendelés #102",
                "Rendelés #103"
            };
            SelectedOrder = Orders[0];

            // Alapértelmezett nézet: üres (csak menü látszik)
            CurrentView = null;
        }

        public ICommand ShowMealsViewCommand => new RelayCommand(() =>
        {
            CurrentView = new MealViewModel();
        });


    }
}
