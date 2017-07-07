using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public partial class Stock
    {
        [Key]
        public int StockId { get; set; }

        public decimal StockBuyingRate { get; set; }

        public decimal StockSellingRate { get; set; }

        public int ProductId { get; set; }

        public virtual Product StockProduct { get; set; }

        public int SupplierId { get; set; }

        public virtual Supplier StockSupplier { get; set; }

        public int CategoryId { get; set; }

        public virtual  Category StockCategory { get; set; }

    }
}