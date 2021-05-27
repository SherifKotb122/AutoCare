namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ServiceModel;

    [Table("Item")]
    public partial class Item
    {
        public int itemID { get; set; }

        [Required]
        [StringLength(50)]
        public string itemName { get; set; }

        public double? itemQuantity { get; set; }

        public double itemPrice { get; set; }

        public double itemCost { get; set; }

        [StringLength(30)]
        public string itemModel { get; set; }
    }
}
