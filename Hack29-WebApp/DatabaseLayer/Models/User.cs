using System;
using System.Collections.Generic;

#nullable disable

namespace Hack29_WebApp.DatabaseLayer.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string PostalCode { get; set; }

        public User()
        {}

        public User(int userId, string firstName, string lastName, string email, string location, string phone, string postalCode)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Location = location;
            this.Phone = phone;
            this.PostalCode = postalCode;
        }
    }
}
