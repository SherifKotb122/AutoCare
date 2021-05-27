namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierBill")]
    public partial class SupplierBill
    {
        [Key]
        [DisplayName("—ﬁ„ «·›« Ê—Â")]
        public int billID { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("«· «—ÌŒ")]
        public DateTime? billDate { get; set; }

        [DisplayName("„·«ÕŸ« ")]
        public string billNotes { get; set; }

        [DisplayName("«·”⁄— ﬁ»· «·Œ’„")]
        public double? billTotablPriceBefore { get; set; }

        [DisplayName("«·«Ã„«·Ï")]
        public double? billTotablPriceAfter { get; set; }

        [DisplayName("«·Œ’„")]
        public double? billDiscount { get; set; }

        [DisplayName("«·„œ›Ê⁄")]
        public double? billCash { get; set; }

        [DisplayName("—ﬁ„ «·„Ê—œ")]
        public int? supplierID { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
