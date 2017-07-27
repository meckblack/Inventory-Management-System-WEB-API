using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        public Product ProductId { get; set; }

        [Display(Name ="Name")]
        public virtual Product PurchaseProduct { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }
    }
}