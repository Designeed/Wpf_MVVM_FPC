using System;
using System.Collections.Generic;

#nullable disable

namespace FPC.Models.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdHistory { get; set; }
        public int OrederDate { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
