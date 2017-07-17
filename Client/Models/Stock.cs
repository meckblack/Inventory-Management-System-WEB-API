using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Buying Rate")]
        [Required(ErrorMessage ="Buying Rate field required")]
        public decimal StockBuyingRate { get; set; }

        [Display(Name = "Selling Rate")]
        [Required(ErrorMessage = "Selling Rate field required")]
        public decimal StockSellingRate { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product name field required")]
        public int ProductId { get; set; }

        public virtual Product StockProduct { get; set; }

        [Display(Name = "Supplier")]
        [Required(ErrorMessage = "Supplier field required")]
        public int SupplierId { get; set; }

        public virtual Supplier StockSupplier { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Category field required")]
        public int CategoryId { get; set; }

        public virtual Category StockCategory { get; set; }
    }
}