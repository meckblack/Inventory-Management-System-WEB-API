using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required(ErrorMessage="Name field required")]
        public string LocationName { get; set; }
    }
}