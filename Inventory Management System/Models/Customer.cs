using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public partial class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Name field required")]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Address field required")]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string CustomerAddress { get; set; }

        [Required(ErrorMessage = "Phone number field required")]
        [Display(Name = "Phone Number")]
        public string CustomerContact { get; set; }
    }
}