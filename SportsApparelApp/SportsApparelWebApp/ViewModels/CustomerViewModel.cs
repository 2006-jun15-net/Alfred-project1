using ApparelApp.Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApparelWebApp.ViewModels
{
    public class CustomerViewModel
    {

        
        public int CustId { get; set; }

        [Required(ErrorMessage = "Please enter student name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter student name.")]
        public string LastName { get; set; }

   

        //public IEnumerable<Customer> customers { get; set; }

        
     
    }
}
