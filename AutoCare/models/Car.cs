namespace AutoCare.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int carID { get; set; }

        public short? carModel { get; set; }

        [StringLength(30)]
        public string carBrand { get; set; }

        [StringLength(50)]
        public string carLicense { get; set; }

        public int? clientID { get; set; }

        public virtual Client Client { get; set; }
    }
}
