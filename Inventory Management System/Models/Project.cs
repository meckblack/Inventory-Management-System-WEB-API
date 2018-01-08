using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public partial class Project
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}