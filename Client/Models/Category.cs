using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name field required")]
        [Display(Name = "Name")]
        public string CategoryName { get; set; }
    }
}