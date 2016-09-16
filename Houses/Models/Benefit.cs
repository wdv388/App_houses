namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Benefit")]
    public partial class Benefit
    {
        public int ID { get; set; }

        public short Privilege { get; set; }

        public short Persons { get; set; }

        public decimal E { get; set; }

        public decimal CW { get; set; }

        public decimal HW { get; set; }

        public decimal S { get; set; }

        public int HomID { get; set; }

        public virtual HomItems HomItems { get; set; }
    }
}
