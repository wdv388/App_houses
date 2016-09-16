namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SewageНабор
    {
        public int ID { get; set; }

        public int S1 { get; set; }

        public int S0 { get; set; }

        public int ST { get; set; }

        public int SP { get; set; }

        public int SD { get; set; }

        public decimal Sum { get; set; }

        public DateTime Data { get; set; }

        public int HomID { get; set; }

        public virtual HomItems HomItems { get; set; }
    }
}
