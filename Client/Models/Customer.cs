using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name field required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address field required")]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone number field required")]
        [Display(Name = "Phone Number")]
        public string Contact { get; set; }
    }
}