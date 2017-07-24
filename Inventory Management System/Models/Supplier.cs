using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public partial class Supplier
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }
    }
}