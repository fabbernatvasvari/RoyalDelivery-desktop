using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace RoyalDelivery.ViewModels
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public string CCV { get; set; }
    }

    public partial class UserViewModel : ObservableObject
    {
        public ObservableCollection<UserModel> Users { get; set; }

        public UserViewModel()
        {
            // dummy data
            Users = new ObservableCollection<UserModel>()
            {
                new UserModel { Name="Kovács Péter", Email="peter.kovacs@email.com", Password="******", CardNumber="1234 5678 9012 3456", Expiry="12/26", CCV="123" },
                new UserModel { Name="Nagy Anna", Email="anna.nagy@email.com", Password="******", CardNumber="9876 5432 1098 7654", Expiry="05/25", CCV="456" },
                new UserModel { Name="Tóth László", Email="laszlo.toth@email.com", Password="******", CardNumber="1111 2222 3333 4444", Expiry="10/24", CCV="789" }
            };
        }
    }
}
