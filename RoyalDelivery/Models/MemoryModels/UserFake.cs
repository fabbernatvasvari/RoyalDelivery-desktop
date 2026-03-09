using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Models.MemoryModels
{
    /// <summary>
    /// Felhasználó.
    /// </summary>
    public sealed class UserFake : ICloneable
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public UserFake()
        {
            
        }

        public UserFake(int id, string? username, string? firstName, string? lastName, string? email, string? address)
        {
            Id = id;
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

        public void Set(UserFake schoolClass)
        {
            Id = schoolClass.Id;
            Username = schoolClass.Username;
            FirstName = schoolClass.FirstName;
            LastName = schoolClass.LastName;
            Email = schoolClass.Email;
            Address = schoolClass.Address;
        }

        public UserFake Clone()
             => new UserFake(Id,Username, FirstName, LastName, Email, Address);
        object ICloneable.Clone() => Clone();
    }
}
