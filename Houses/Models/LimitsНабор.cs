namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LimitsНабор
    {
        public int ID { get; set; }

        public int E_L1 { get; set; }

        public int E_L2 { get; set; }

        public int E_L3 { get; set; }

        public int HomID { get; set; }

        public virtual HomItems HomItems { get; set; }
    }
}
