using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Controls;

namespace RoyalDelivery.ViewModels
{
    public partial class MainWindowViewModel: ObservableObject
    {
        // Example: list of orders
        [ObservableProperty]
        private ObservableCollection<string> orders;

        // Example: selected order
        [ObservableProperty]
        private string selectedOrder;

        [ObservableProperty]
        private ObservableCollection<string> menuItems = new ObservableCollection<string>()
        {
            "Pizza Margherita",
            "Gyros tál",
            "Hamburger menü"
        };


        // Example: button command
        [RelayCommand]
        private void AddOrder()
        {
            Orders.Add($"Rendelés #{Orders.Count + 1}");
        }

        public MainWindowViewModel()
        {
            Orders = new ObservableCollection<string>()
            {
                "Rendelés #101",
                "Rendelés #102",
                "Rendelés #103"
            };
            SelectedOrder = Orders[0];
        }
    }
}
