﻿using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name field required")]
        [Display(Name = "Name")]
        public string CategoryName { get; set; }
    }
}