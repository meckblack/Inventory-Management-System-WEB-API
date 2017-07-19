using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Management_System.Models
{
    public partial class Stock
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("StockProduct")]
        public int ProductId { get; set; }

        public virtual Product StockProduct { get; set; }

        [ForeignKey("StockSupplier")]
        public int SupplierId { get; set; }

        public virtual Supplier StockSupplier { get; set; }

        [ForeignKey("StockCategory")]
        public int CategoryId { get; set; }

        public virtual Category StockCategory { get; set; }

        public int StockQuantity { get; set; }

    }
}