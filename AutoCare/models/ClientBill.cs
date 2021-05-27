namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientBill")]
    public partial class ClientBill
    {
        [Key]
        [DisplayName("ÑŞã ÇáİÇÊæÑå")]
        public int billID { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("ÇáÊÇÑíÎ")]
        public DateTime? billDate { get; set; }
        [DisplayName("ãáÇÍÙÇÊ")]
        public string billNotes { get; set; }
        [DisplayName("ÇáÚÏÇÏ")]
        public int? billKilometerCount { get; set; }
        [DisplayName("ÇáÓÚÑ ŞÈá ÇáÎÕã")]
        public double? billTotablPriceBefore { get; set; }
        [DisplayName("ÇáÇÌãÇáì")]
        public double? billTotablPriceAfter { get; set; }
        [DisplayName("ÇáÎÕã")]
        public double? billDiscount { get; set; }
        [DisplayName("ÇáãÏİæÚ")]
        public double? billCash { get; set; }
        [DisplayName("Úãæáå ÇáÚÇãá")]
        public double? billWorkerHandPrice { get; set; }
        [DisplayName("ÑŞã ÇáÚãíá")]
        public int? clientID { get; set; }

        public virtual Client Client { get; set; }
    }
}
