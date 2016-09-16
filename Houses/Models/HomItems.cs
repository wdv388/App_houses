namespace Houses
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HomItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HomItems()
        {
            Benefit1 = new HashSet<Benefit>();
            Cold_WaterНабор = new HashSet<Cold_WaterНабор>();
            ElectricityНабор = new HashSet<ElectricityНабор>();
            GasНабор = new HashSet<GasНабор>();
            Hot_WaterНабор = new HashSet<Hot_WaterНабор>();
            LimitsНабор = new HashSet<LimitsНабор>();
            SewageНабор = new HashSet<SewageНабор>();
            TarrifНабор = new HashSet<TarrifНабор>();
        }

        public int ID { get; set; }

        public int Apartament_naber { get; set; }

        public bool Benefit { get; set; }

        public bool Gas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Benefit> Benefit1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cold_WaterНабор> Cold_WaterНабор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElectricityНабор> ElectricityНабор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GasНабор> GasНабор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hot_WaterНабор> Hot_WaterНабор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LimitsНабор> LimitsНабор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SewageНабор> SewageНабор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarrifНабор> TarrifНабор { get; set; }
    }
}
