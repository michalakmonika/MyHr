using Microsoft.EntityFrameworkCore;
using MyHr.Domain.Entities;

namespace MyHr.Infrastructure.Persistence
{
    public class MyHrDbContext : DbContext
    {
        public MyHrDbContext(DbContextOptions<MyHrDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .OwnsOne(e => e.Address);
        }
    }
}
