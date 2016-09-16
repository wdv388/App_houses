namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GasНабор
    {
        public int ID { get; set; }

        public int GC { get; set; }

        public int GP { get; set; }

        public int GD { get; set; }

        public int? Privelege { get; set; }

        public decimal Sum { get; set; }

        public DateTime Data { get; set; }

        public int HomID { get; set; }

        public virtual HomItems HomItems { get; set; }
    }
}
