using System;
using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Name field required")]
        [Display(Name="Name")]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public virtual Category ProductCategory { get; set; }

        [Required(ErrorMessage = "Price field required")]
        [Display(Name = "Price")]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "Description field required")]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Date field required")]
        [Display(Name = "Date")]
        public DateTime ProductDate { get; set; }

        [Required(ErrorMessage = "Model field required")]
        [Display(Name = "Model")]
        public string ProductModel { get; set; }
    }
}