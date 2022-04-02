using EFCoreInheritanceTests.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreInheritanceTests.Data
{
    public class VehiclesTPTContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Motorbike> Motorcycles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Initial catalog=EFCoreInheritanceTestsTPT;Persist Security Info=True;Integrated Security=SSPI;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Motorbike>().ToTable("Motorbikes");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
        }
    }
}
