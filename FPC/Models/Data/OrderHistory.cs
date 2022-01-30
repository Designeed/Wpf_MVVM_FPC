using System;
using System.Collections.Generic;

#nullable disable

namespace FPC.Models.Data
{
    public partial class OrderHistory
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }

        public virtual Order IdOrderNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
    }
}
