using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public class FixedAsset
    {
        [Key]
        public int FixedAssetId { get; set; }

        public string FixedAssetName { get; set; }

        public DateTime FixedAssetDate { get; set; }

        public decimal FixedAssetAmount { get; set; }

        public decimal FixedAssetDepreciation { get; set; }

        public int LocationId { get; set; }

        public virtual Location FixedAssetLocation { get; set; }

        public int CategoryId { get; set; }

        public virtual Category FixedAssetCategory { get; set; }


    }
}