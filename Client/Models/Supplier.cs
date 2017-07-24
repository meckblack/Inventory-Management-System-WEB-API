using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Supplier
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address field is required")]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Contact field is required")]
        [Display(Name = "Phone Number")]
        public string Contact { get; set; }
    }
}