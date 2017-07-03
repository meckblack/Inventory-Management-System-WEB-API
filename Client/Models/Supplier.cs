using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Contact field is required")]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string SupplierContact { get; set; }

        [Required(ErrorMessage = "Address field is required")]
        [Display(Name = "Phone Number")]
        public string SupplierAddress { get; set; }
    }
}