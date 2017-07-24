using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name field required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}