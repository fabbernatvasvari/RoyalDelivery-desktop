using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using RoyalDelivery.Models;
namespace RoyalDelivery.ViewModels
{

    public partial class UserViewModel : ObservableObject
    {
        public ObservableCollection<User> Users { get; }

        public UserViewModel()
        {
            // dummy data
            Users = new ObservableCollection<User>()
            {
                new User { Name="Kovács Péter", Email="peter.kovacs@email.com", Password="Peter123", CardNumber="1234 5678 9012 3456", BillingAddress = "1234 Szeged Kovács Péter utca 1." },
                new User { Name="Nagy Anna", Email="anna.nagy@email.com", Password="Anna1234", CardNumber="9876 5432 1098 7654", BillingAddress = "1234 Cegléd Nagy Anna utca 2." },
                new User {Name = "Tóth László", Email = "laszlo.toth@email.com", Password = "Laci1234", CardNumber = "1111 2222 3333 4444", BillingAddress = "1234 Budapest Tóth Laci utca 69."}
            };
        }
    }
}
