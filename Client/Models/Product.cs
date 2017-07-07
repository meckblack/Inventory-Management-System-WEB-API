using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage="Name field required")]
        [Display(Name="Name")]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public virtual Category ProductCategory { get; set; }
    }
}