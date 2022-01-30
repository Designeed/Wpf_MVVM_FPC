﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FPC.Models.Entities
{
    public partial class Basket
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
