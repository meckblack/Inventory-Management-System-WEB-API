using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Management_System.Models
{
    public partial class Store
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("StoreProduct")]
        public int ProductId { get; set; }

        public virtual Product StoreProduct { get; set; }

        [ForeignKey("StoreSupplier")]
        public int SupplierId { get; set; }

        public virtual Supplier StoreSupplier { get; set; }

        public int AvailableQuantity { get; set; }

    }
}