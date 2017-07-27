using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    public partial class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}