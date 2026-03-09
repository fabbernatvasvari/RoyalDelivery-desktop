using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RoyalDelivery.Models.MemoryModels;
using RoyalDelivery.Repos.MemoryRepo;
using RoyalDelivery.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Controls;
namespace RoyalDelivery.ViewModels.Pages
{

    public partial class UserViewModel : ViewModelBase
    {
        private readonly UserMemoryRepo _repo;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private UserFake? selectedUser;


        /// <summary>
        /// A szerkesztett adat új adat-e
        /// </summary>
        public bool IsNew => EditingUser != null && EditingUser.Id == 0;

        [ObservableProperty]
        private UserFake? editingUser;
        partial void OnSelectedUserChanged(UserFake? value)
        {
            if (value is not null)
                EditingUser = value.Clone();
        }

        public ObservableCollection<UserFake> Users { get; }

        public UserViewModel()
        {
            
        }

        public UserViewModel(UserMemoryRepo userRepo)
        {
            _repo = userRepo;
            Users = new ObservableCollection<UserFake>(_repo.GetAll());
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
