using System;
using System.Collections.Generic;

namespace ApparelApp.Entities.Entities
{
    public partial class InventoryStocked
    {
        public int StoreId { get; set; }
        public int ProdId { get; set; }
        public int? Stock { get; set; }

        public virtual Product Prod { get; set; }
        public virtual Store Store { get; set; }
    }
}
