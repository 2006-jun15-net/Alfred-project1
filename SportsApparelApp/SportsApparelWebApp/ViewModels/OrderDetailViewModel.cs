using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApparelWebApp.ViewModels
{
    public class OrderDetailViewModel
    {
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public int? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalCost { get; set; }



    }
}
