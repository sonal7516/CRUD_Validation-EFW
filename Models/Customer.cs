using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_EFW.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name ="Employee Name")]
        [Required]
        public string Cust_Name { get; set; }

        [Display(Name = "Employee Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Email address is not valid!")]
        public string Cust_Email { get; set; }

        [Display(Name = "Employee Address")]
        [Required]
        [MaxLength(100,ErrorMessage ="Max char can't be more than 100!")]
        public string Cust_Address { get; set; }

        [Display(Name = "Employee Mobile Number")]
        [Required]
        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", ErrorMessage ="Inavlid mobile number!")]
        public string Mobile { get; set; }

    }
}
