using System;
using System.Collections.Generic;
using System.Text;

namespace RoyalDelivery.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CardNumber { get; set; }
        public string BillingAddress { get; set; }
    }
}
