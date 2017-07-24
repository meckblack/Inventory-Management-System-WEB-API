using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Store
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity field required")]
        public int AvailableQuantity { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product name field required")]
        public int ProductId { get; set; }

        public virtual Product StockProduct { get; set; }

        [Display(Name = "Supplier")]
        [Required(ErrorMessage = "Supplier field required")]
        public int SupplierId { get; set; }

        public virtual Supplier StockSupplier { get; set; }
        
    }
}