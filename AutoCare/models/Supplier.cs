namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            SupplierBills = new HashSet<SupplierBill>();
        }

        public int supplierID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("«”„ «·„Ê—œ")]
        public string supplierName { get; set; }

        [StringLength(50)]
        public string supplierAddress { get; set; }

        [StringLength(11)]
        public string supplierPhoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierBill> SupplierBills { get; set; }
    }
}
