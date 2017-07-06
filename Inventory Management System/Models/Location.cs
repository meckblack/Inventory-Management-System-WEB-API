using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        public string LocationName { get; set; }
    }
}