using RoyalDelivery.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RoyalDelivery.Repos
{
    public class UserRepo
    {
        private List<User> _items = new()
        {
            new User { Username = "jdoe", FirstName = "John", LastName = "Doe", Email = "jdoe@email.com", Address = "123 Main Street" },
            new User { Username = "asmith", FirstName = "Anna", LastName = "Smith", Email = "asmith@email.com", Address = "45 King Road" },
            new User { Username = "bkovacs", FirstName = "Béla", LastName = "Kovács", Email = "bkovacs@email.com", Address = "12 Petőfi utca" },
            new User { Username = "nagy.eva", FirstName = "Éva", LastName = "Nagy", Email = "eva.nagy@email.com", Address = "78 Kossuth tér" },
            new User { Username = "tpeter", FirstName = "Péter", LastName = "Tóth", Email = "tpeter@email.com", Address = "9 Rákóczi út" },
            new User { Username = "kzsuzsa", FirstName = "Zsuzsa", LastName = "Kiss", Email = "kzsuzsa@email.com", Address = "33 Ady Endre utca" },
            new User { Username = "fmark", FirstName = "Márk", LastName = "Farkas", Email = "fmark@email.com", Address = "5 Béke tér" },
            new User { Username = "ghorvath", FirstName = "Gábor", LastName = "Horváth", Email = "ghorvath@email.com", Address = "101 Duna sor" },
            new User { Username = "lbalazs", FirstName = "Balázs", LastName = "Lakatos", Email = "lbalazs@email.com", Address = "67 Arany János utca" },
            new User { Username = "mrita", FirstName = "Rita", LastName = "Molnár", Email = "mrita@email.com", Address = "22 Széchenyi utca" }
        };

        public IEnumerable<User> GetAll()
        {
            return _items.ToList();
        }

        internal void Remove(int id)
        {
            Console.WriteLine("Törlés");
        }
    }
}