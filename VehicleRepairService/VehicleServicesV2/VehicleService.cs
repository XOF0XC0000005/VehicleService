using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VehicleServicesV2
{
    public partial class VehicleService : DbContext
    {
        public VehicleService()
            : base("name=VehicleService3")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Employee_TypeWork> Employee_TypeWork { get; set; }
        public virtual DbSet<MaintanceService> MaintanceService { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeWork> TypeWork { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<VehicleType_TypeWork> VehicleType_TypeWork { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeWork>()
                .HasMany(e => e.Employee_TypeWork)
                .WithRequired(e => e.TypeWork)
                .WillCascadeOnDelete(false);
        }
    }
}
