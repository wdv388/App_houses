namespace Houses
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model_connect")
        {
        }

        public virtual DbSet<Benefit> Benefit { get; set; }
        public virtual DbSet<Cold_WaterНабор> Cold_WaterНабор { get; set; }
        public virtual DbSet<ElectricityНабор> ElectricityНабор { get; set; }
        public virtual DbSet<GasНабор> GasНабор { get; set; }
        public virtual DbSet<HomItems> HomItems { get; set; }
        public virtual DbSet<Hot_WaterНабор> Hot_WaterНабор { get; set; }
        public virtual DbSet<LimitsНабор> LimitsНабор { get; set; }
        public virtual DbSet<SewageНабор> SewageНабор { get; set; }
        public virtual DbSet<TarrifНабор> TarrifНабор { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Benefit>()
                .Property(e => e.E)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Benefit>()
                .Property(e => e.CW)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Benefit>()
                .Property(e => e.HW)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Benefit>()
                .Property(e => e.S)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Cold_WaterНабор>()
                .Property(e => e.Sum)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ElectricityНабор>()
                .Property(e => e.SumP)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ElectricityНабор>()
                .Property(e => e.SumT)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ElectricityНабор>()
                .Property(e => e.SumF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ElectricityНабор>()
                .Property(e => e.Sum)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ElectricityНабор>()
                .Property(e => e.SumO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<GasНабор>()
                .Property(e => e.Sum)
                .HasPrecision(18, 6);

            modelBuilder.Entity<HomItems>()
                .HasMany(e => e.Benefit1)
                .WithRequired(e => e.HomItems)
                .HasForeignKey(e => e.HomID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HomItems>()
                .HasMany(e => e.Cold_WaterНабор)
                .WithRequired(e => e.HomItems)
                .HasForeignKey(e => e.HomID);

            modelBuilder.Entity<HomItems>()
                .HasMany(e => e.ElectricityНабор)
                .WithRequired(e => e.HomItems)
                .HasForeignKey(e => e.HomID);

            modelBuilder.Entity<HomItems>()
                .HasMany(e => e.GasНабор)
                .WithRequired(e => e.HomItems)
                .HasForeignKey(e => e.HomID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HomItems>()
                .HasMany(e => e.Hot_WaterНабор)
                .WithRequired(e => e.HomItems)
                .HasForeignKey(e => e.HomID);

            modelBuilder.Entity<HomItems>()
                .HasMany(e => e.LimitsНабор)
                .WithRequired(e => e.HomItems)
                .HasForeignKey(e => e.HomID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HomItems>()
                .HasMany(e => e.SewageНабор)
                .WithRequired(e => e.HomItems)
                .HasForeignKey(e => e.HomID);

            modelBuilder.Entity<HomItems>()
                .HasMany(e => e.TarrifНабор)
                .WithRequired(e => e.HomItems)
                .HasForeignKey(e => e.HomID);

            modelBuilder.Entity<Hot_WaterНабор>()
                .Property(e => e.Sum)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SewageНабор>()
                .Property(e => e.Sum)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TarrifНабор>()
                .Property(e => e.CW)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TarrifНабор>()
                .Property(e => e.HW)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TarrifНабор>()
                .Property(e => e.S)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TarrifНабор>()
                .Property(e => e.E_T)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TarrifНабор>()
                .Property(e => e.E_F)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TarrifНабор>()
                .Property(e => e.E_O)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TarrifНабор>()
                .Property(e => e.Gas)
                .HasPrecision(18, 6);
        }
    }
}
