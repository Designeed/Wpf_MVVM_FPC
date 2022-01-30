using System;
using System.Collections.Generic;

#nullable disable

namespace FPC.Models.Entities
{
    public partial class TypeProduct
    {
        public TypeProduct()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
