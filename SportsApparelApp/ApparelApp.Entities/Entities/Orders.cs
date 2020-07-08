using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApparelApp.Entities.Entities
{
    public partial class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int CustId { get; set; }

        public virtual Customer Cust { get; set; }
    }
}
