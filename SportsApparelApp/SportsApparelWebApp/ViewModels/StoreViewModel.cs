using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApparelWebApp.ViewModels
{
    public class StoreViewModel
    {

        [Key]
        public int StoreId { get; set; }


        [Required]
        public string Location { get; set; }




    }
}
