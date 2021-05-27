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
        [DisplayName("��� ��������")]
        public int billID { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("�������")]
        public DateTime? billDate { get; set; }

        [DisplayName("�������")]
        public string billNotes { get; set; }

        [DisplayName("����� ��� �����")]
        public double? billTotablPriceBefore { get; set; }

        [DisplayName("��������")]
        public double? billTotablPriceAfter { get; set; }

        [DisplayName("�����")]
        public double? billDiscount { get; set; }

        [DisplayName("�������")]
        public double? billCash { get; set; }

        [DisplayName("��� ������")]
        public int? supplierID { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
