using LogisticsVersta24.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticsVersta24.Persistance
{
    public class ApplicationDBcontext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
