namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Worker")]
    public partial class Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Worker()
        {
            WorkerAdvancePayments = new HashSet<WorkerAdvancePayment>();
        }

        public int workerID { get; set; }

        [Required]
        [StringLength(50)]
        public string workerName { get; set; }

        [StringLength(11)]
        public string workerPhoneNumber { get; set; }

        public double workerSalary { get; set; }

        [Column(TypeName = "date")]
        public DateTime? workerStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? workerEndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkerAdvancePayment> WorkerAdvancePayments { get; set; }
    }
}
