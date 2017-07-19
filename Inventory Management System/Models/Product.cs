using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public partial class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public virtual Category ProductCategory { get; set; }

        public decimal ProductPrice { get; set; }

        public string Description { get; set; }

        public DateTime ProductDate { get; set; }

        public string ProductModel { get; set; }
    }
}