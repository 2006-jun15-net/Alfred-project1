using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApparelWebApp.ViewModels
{
    public class OrderViewModel
    {

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Datecreated { get; set; }
        public decimal FinalAmount { get; set; }
        public IEnumerable<OrderDetailViewModel> orderDetailViewModels { get; set; }


    }
}
