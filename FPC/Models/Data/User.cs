using System;
using System.Collections.Generic;

#nullable disable

namespace FPC.Models.Data
{
    public partial class User
    {
        public User()
        {
            Baskets = new HashSet<Basket>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
