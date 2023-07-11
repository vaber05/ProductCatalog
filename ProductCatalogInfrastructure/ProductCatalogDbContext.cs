using Microsoft.EntityFrameworkCore;
using ProductCatalogDomain.Models;

namespace ProductCatalogInfrastructure;

public class ProductCatalogDbContext : DbContext
{
    public ProductCatalogDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Subcategory> Subcategories { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<PriceChangeRecord> PriceChangeRecords { get; set; }
}
