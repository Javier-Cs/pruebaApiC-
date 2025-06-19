using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace pruebaApiC_.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options) { 
        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductModel>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
