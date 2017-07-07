using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public partial class Location
    {
        [Key]
        public int LocationId { get; set; }

        public string LocationName { get; set; }
    }
}