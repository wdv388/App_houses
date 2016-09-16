namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TarrifНабор
    {
        public int ID { get; set; }

        public decimal CW { get; set; }

        public decimal HW { get; set; }

        public decimal S { get; set; }

        public decimal E_T { get; set; }

        public decimal E_F { get; set; }

        public decimal? E_O { get; set; }

        public int HomID { get; set; }

        public decimal Gas { get; set; }

        public virtual HomItems HomItems { get; set; }
    }
}
