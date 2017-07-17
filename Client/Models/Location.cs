using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Name field required")]
        [Display(Name ="Name")]
        public string LocationName { get; set; }
    }
}