﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public partial class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name field is required")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage ="Contact field is required")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.MultilineText)]
        public string SupplierContact { get; set; }

        [Required(ErrorMessage ="Address field is required")]
        [Display(Name = "Address")]
        public string SupplierAddress { get; set; }
    }
}