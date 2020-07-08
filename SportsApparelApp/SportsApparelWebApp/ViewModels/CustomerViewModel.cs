using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApparelWebApp.ViewModels
{
    public class CustomerViewModel
    {

        [Key]
        public int CustId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

    }
}
