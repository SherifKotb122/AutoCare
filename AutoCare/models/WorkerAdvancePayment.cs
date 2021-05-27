namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkerAdvancePayment")]
    public partial class WorkerAdvancePayment
    {
        public int WorkerAdvancePaymentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WorkerAdvancePaymentDate { get; set; }

        public bool? WorkerAdvancePaymentType { get; set; }

        public double? WorkerAdvancePaymentAmount { get; set; }

        public int? workerID { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
