﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ApparelApp.Entities.Entities
{
    public partial class Product
    {

        [Key]
        public int ProdId { get; set; }
        public string Name { get; set; }
    }
}
