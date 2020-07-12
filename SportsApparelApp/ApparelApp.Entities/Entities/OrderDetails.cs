using System;
using System.Collections.Generic;

namespace ApparelApp.Entities.Entities
{
    public partial class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public int? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalCost { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Product Prod { get; set; }
    }
}
