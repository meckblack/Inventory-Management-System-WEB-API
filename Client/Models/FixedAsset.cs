using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class FixedAsset
    {
        [Key]
        public int FixedAssetId { get; set; }

        [Required(ErrorMessage ="Asset Name field required")]
        [Display(Name = "Asset Name")]
        public string FixedAssetName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name ="Date Aquired")]
        public DateTime FixedAssetDate { get; set; }

        [Required(ErrorMessage ="Amount Aquired field required")]
        [Display(Name ="Amount Aquired")]
        public decimal FixedAssetAmount { get; set; }

        [Display(Name = "Despreciation")]
        public decimal FixedAssetDepreciation { get; set; }

        [Required(ErrorMessage = "Location Of Asset field Required")]
        [Display(Name = "Location Of Asset")]
        public int LocationId { get; set; }

        public virtual Location FixedAssetLocation { get; set; }

        [Required(ErrorMessage = "Category Of Asset field Required")]
        [Display(Name = "Category Of Asset")]
        public int CategoryId { get; set; }

        public virtual Category FixedAssetCategory { get; set; }
    }
}