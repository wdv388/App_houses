namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cold_WaterНабор
    {
        public int ID { get; set; }

        public int CW1 { get; set; }

        public int CW0 { get; set; }

        public int CWT { get; set; }

        public int CWP { get; set; }

        public int CWD { get; set; }

        public decimal Sum { get; set; }

        public int HomID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public virtual HomItems HomItems { get; set; }
    }
}
