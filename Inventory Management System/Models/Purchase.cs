using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public partial class Purchase
    {
        [Key]
        public int Id { get; set; }

        public Product ProductId { get; set; }

        public virtual Product PurchaseProduct { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }
    }
}