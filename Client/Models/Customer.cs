using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Name field required")]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Address field required")]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string CustomerAddress { get; set; }

        [Required(ErrorMessage = "Phone number field required")]
        [Display(Name = "Phone Number")]
        public string CustomerContact { get; set; }
    }
}