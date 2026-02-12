using CommunityToolkit.Mvvm.ComponentModel;
using RoyalDelivery.Models;
using RoyalDelivery.Repos;
using System.Collections.ObjectModel;
namespace RoyalDelivery.ViewModels
{

    public partial class UserViewModel : ObservableObject
    {
        private readonly UserRepo _repo = new();

        public ObservableCollection<User> Users { get; }

        public UserViewModel()
        {
            Users = new ObservableCollection<User>(_repo.GetAll());
        }
    }
}
