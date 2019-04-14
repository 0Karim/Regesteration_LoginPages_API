using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Regesteration_LoginPages_API.Models
{
    public class Employees
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50 , ErrorMessage ="Your Name Exceed 50 Letter")]
        public string FirstName { get; set; }

        [StringLength(50 , ErrorMessage ="Your Last Name Exceed 50 Letter")]
        public string LastName { get; set; }

        public string Gender { get; set; }

        public int Salary { get; set; }

    }
}