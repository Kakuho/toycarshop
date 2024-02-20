using VroomVroom.Models;
using Microsoft.EntityFrameworkCore;

namespace VroomVroom.Data
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
              .Entity<Car>()
              .Property(c => c.Price)
              .HasConversion(
                 p => Decimal.ToDouble(p),
                 p => Convert.ToDecimal(p)
              );
            modelBuilder.Entity<Car>().ToTable("Product");

        }
    }
}
