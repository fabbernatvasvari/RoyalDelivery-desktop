using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Models
{
    /// <summary>
    /// Felhasználó.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        private static int _nextId = 1;

        public User()
        {
            Id = _nextId++;
        }

        public User(string? username, string? firstName, string? lastName, string? email, string? address)
        {
            Id = _nextId++;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
        }

        public override string ToString()
        {
            return $"A felhasználó adatai: Id={Id}, Username={Username}, FirstName={FirstName}, LastName={LastName}, Email={Email}, Address={Address}";
        }
    }
}
