using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models.DbMysqlModels;
using RoyalDelivery.Repos.Interface;
using RoyalDelivery.ViewModels.Base;
using System.Collections.ObjectModel;

namespace RoyalDelivery.ViewModels.Pages
{
    public partial class MealViewModel : ViewModelBase
    {
        private readonly IMealRepo _repo;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private Meal? selectedMeal;

        [ObservableProperty]
        private ObservableCollection<Meal> meals;

        public MealViewModel()
        {
        }

        public MealViewModel(IMealRepo mealRepo)
        {
            _repo = mealRepo;
            meals = new ObservableCollection<Meal>(_repo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDelete))]
        private void DeleteSelected()
        {
            //if (SelectedMeal == null) return;
            //_repo.Remove(SelectedMeal.Id);
            //meals.Remove(SelectedMeal);
            //SelectedMeal = null;
        }

        private bool CanDelete()
        {
            return SelectedMeal != null;
        }
    }
}
