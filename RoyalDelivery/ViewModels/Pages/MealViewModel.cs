using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models;
using RoyalDelivery.Repos;
using RoyalDelivery.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RoyalDelivery.ViewModels
{
    public partial class MealViewModel : ViewModelBase
    {
        private readonly MealRepo _repo;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private Meal? selectedMeal;

        [ObservableProperty]
        private ObservableCollection<Meal> meals;

        public MealViewModel(MealRepo mealRepo)
        {
            _repo = mealRepo;
            Meals = new ObservableCollection<Meal>(_repo.GetAll());
        }

                [RelayCommand(CanExecute = nameof(CanDelete))]
        private void DeleteSelected()
        {
            if (SelectedMeal == null) return;
            _repo.Remove(SelectedMeal.Id);
            Meals.Remove(SelectedMeal);
            SelectedMeal = null;
        }

        private bool CanDelete()
        {
            return SelectedMeal != null;
        }
    }
}
