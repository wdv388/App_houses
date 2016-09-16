namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ElectricityНабор
    {
        public int ID { get; set; }

        public int EC { get; set; }

        public int EP { get; set; }

        public int ED { get; set; }

        public int Privelege { get; set; }

        public int toLim { get; set; }

        public int fromLim { get; set; }

        public int? overLim { get; set; }

        public decimal SumP { get; set; }

        public decimal SumT { get; set; }

        public decimal SumF { get; set; }

        public decimal Sum { get; set; }

        public decimal? SumO { get; set; }

        public DateTime Data { get; set; }

        public int HomID { get; set; }

        public virtual HomItems HomItems { get; set; }
    }
}
