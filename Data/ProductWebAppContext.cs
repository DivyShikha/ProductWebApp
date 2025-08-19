using Microsoft.EntityFrameworkCore;
using ProductWebApp.Models;

namespace ProductWebApp.Data
{
    public class ProductWebAppContext : DbContext
    {
        public ProductWebAppContext() { }

        public ProductWebAppContext(DbContextOptions<ProductWebAppContext> options) : base(options)
        {
        }

        // Hardcoded connection string (matches your server & DB)
        // Tip: for production, prefer appsettings.json + DI.
        static string connectionString =
            @"Data Source=IBM-FNZ3SB4\SQLEXPRESS;Initial Catalog=ProductDB;TrustServerCertificate=True;Integrated Security=True;";

        public DbSet<Product> Product { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If you want DI to win when provided, uncomment the guard:
            // if (!optionsBuilder.IsConfigured)
            // {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
            // }
        }

        // Optional: map explicitly to the "Product" table
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Product>().ToTable("Product");
        //     base.OnModelCreating(modelBuilder);
        // }
    }
}
