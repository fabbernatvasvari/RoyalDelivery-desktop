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

        // ---------- Orders ----------
        [ObservableProperty]
        private ObservableCollection<Order> orders;

        [ObservableProperty]
        private Order selectedOrder;

        // ---------- Menu Items ----------
        [ObservableProperty]
        private ObservableCollection<Order> menuItems = new ObservableCollection<Order>()
        {
             new Order { Name = "Pizza", Meals = new List<Meal>(), },
            new Order { Name = "Gyros", Meals = new List<Meal>(), },
            new Order { Name = "Hamburger", Meals = new List<Meal>(), },
            new Order { Name = "Sült csirke", Meals = new List<Meal>(), },
            new Order { Name = "Sült krumpli", Meals = new List<Meal>(), },
            new Order { Name = "Kóla", Meals = new List<Meal>(), }
        };

        // ---------- Commands ----------
        [RelayCommand]
        private void AddOrder()
        {
            Orders.Add(new Order { Name = $"Rendelés #{Orders.Count + 1}", Meals = new List<Meal>(), });
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
            Orders = new ObservableCollection<Order>()
            {
                new Order { Name = "Pizza", Meals = new List<Meal>(), },
            new Order { Name = "Gyros", Meals = new List<Meal>(), },
            new Order { Name = "Hamburger", Meals = new List<Meal>(), },
            new Order { Name = "Sült csirke", Meals = new List<Meal>(), },
            new Order { Name = "Sült krumpli", Meals = new List<Meal>(), },
            new Order { Name = "Kóla", Meals = new List<Meal>(), }
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
