using System;
using System.Collections.Generic;

#nullable disable

namespace Hack29_WebApp.DatabaseLayer.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string PostalCode { get; set; }
    }
}
