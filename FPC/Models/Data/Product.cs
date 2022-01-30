using System;
using System.Collections.Generic;

#nullable disable

namespace FPC.Models.Data
{
    public partial class Product
    {
        public Product()
        {
            Baskets = new HashSet<Basket>();
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdTypeProducte { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string PathImage { get; set; }

        public virtual TypeProduct IdTypeProducteNavigation { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
