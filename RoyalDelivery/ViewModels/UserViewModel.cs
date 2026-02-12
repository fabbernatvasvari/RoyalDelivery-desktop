using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models;
using RoyalDelivery.Repos;
using System.Collections.ObjectModel;
using System.Windows.Controls;
namespace RoyalDelivery.ViewModels
{

    public partial class UserViewModel : ObservableObject
    {
        private readonly UserRepo _repo = new();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private User? selectedUser;


        /// <summary>
        /// A szerkesztett adat új adat-e
        /// </summary>
        public bool IsNew => EditingUser != null && EditingUser.Id == 0;

        [ObservableProperty]
        private User? editingUser;
        partial void OnSelectedUserChanged(User? value)
        {
            if (value is not null)
                EditingUser = value.Clone();
        }

        public ObservableCollection<User> Users { get; }

        public UserViewModel()
        {
            Users = new ObservableCollection<User>(_repo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDelete))]
        private void DeleteSelected()
        {
            if (SelectedUser == null) return;
            _repo.Remove(SelectedUser.Id);
            Users.Remove(SelectedUser);
            SelectedUser = null;
        }

        private bool CanDelete()
        {
            return SelectedUser != null;
        }
    }
}
