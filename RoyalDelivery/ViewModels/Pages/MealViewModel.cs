using CommunityToolkit.Mvvm.ComponentModel;
using RoyalDelivery.Models;
using RoyalDelivery.Repos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RoyalDelivery.ViewModels
{
    public partial class MealViewModel : ObservableObject
    {
        private readonly MealRepo _repo = new();

        [ObservableProperty]
        private ObservableCollection<Meal> meals;

        public MealViewModel()
        {
            Meals = new ObservableCollection<Meal>(_repo.GetAll());
        }
    }
}
