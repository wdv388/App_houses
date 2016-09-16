namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hot_WaterНабор
    {
        public int ID { get; set; }

        public int HW1 { get; set; }

        public int HW0 { get; set; }

        public int HWT { get; set; }

        public int HWP { get; set; }

        public int HWD { get; set; }

        public decimal Sum { get; set; }

        public int HomID { get; set; }

        public DateTime Data { get; set; }

        public virtual HomItems HomItems { get; set; }
    }
}
