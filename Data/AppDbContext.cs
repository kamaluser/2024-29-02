using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-IGIN0GLR\\SQLEXPRESS;Database=AppDb2;Trusted_Connection=true");
        }
    }
}
