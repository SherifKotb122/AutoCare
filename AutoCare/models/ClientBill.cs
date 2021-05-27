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
        [DisplayName("��� ��������")]
        public int billID { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("�������")]
        public DateTime? billDate { get; set; }
        [DisplayName("�������")]
        public string billNotes { get; set; }
        [DisplayName("������")]
        public int? billKilometerCount { get; set; }
        [DisplayName("����� ��� �����")]
        public double? billTotablPriceBefore { get; set; }
        [DisplayName("��������")]
        public double? billTotablPriceAfter { get; set; }
        [DisplayName("�����")]
        public double? billDiscount { get; set; }
        [DisplayName("�������")]
        public double? billCash { get; set; }
        [DisplayName("����� ������")]
        public double? billWorkerHandPrice { get; set; }
        [DisplayName("��� ������")]
        public int? clientID { get; set; }

        public virtual Client Client { get; set; }
    }
}
