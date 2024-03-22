using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProductsApi.Models
{
    public class ProductsContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, ProductName = "Iphone 10", Price = 15000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, ProductName = "Iphone 11", Price = 25000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, ProductName = "Iphone 12", Price = 35000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, ProductName = "Iphone 13", Price = 45000, IsActive = false });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 5, ProductName = "Iphone 14", Price = 55000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 6, ProductName = "Iphone 15", Price = 65000, IsActive = true });
        }
        public DbSet<Product> Products { get; set; }
    }
}
