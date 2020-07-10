using System;
using System.Collections.Generic;

namespace ApparelApp.Entities.Entities
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int CustId { get; set; }

        public virtual Customer Cust { get; set; }
    }
}
