using System;
using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage="Name field required")]
        [Display(Name="Name")]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category ProductCategory { get; set; }

        [Required(ErrorMessage = "Price field required")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description field required")]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Date field required")]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        
    }
}