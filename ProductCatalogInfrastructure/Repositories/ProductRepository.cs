using Microsoft.EntityFrameworkCore;
using ProductCatalogApplication.Abstractions;
using ProductCatalogDomain.Models;

namespace ProductCatalogInfrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ProductCatalogDbContext context;

    public ProductRepository(ProductCatalogDbContext context)
    {
        this.context = context;
    }

    public async Task CreateProduct(Product productDto)
    {
        await context.Products.AddAsync(productDto);

        await context.SaveChangesAsync();
    }

    public async Task DeleteProduct(int id)
    {
        var productToDelete = await context.Products.FirstOrDefaultAsync(p => p.Id == id);

        if (productToDelete is null)
            return;

        context.Products.Remove(productToDelete);

        await context.SaveChangesAsync();
    }

    public async Task<List<Product>> GetAllProducts()
    {
        return await context.Products.Include(p => p.PriceUpdates).ToListAsync();
    }

    public async Task<Product> GetProductById(int id)
    {
        return await context.Products.FirstOrDefaultAsync(p => p.Id == id) ?? new();
    }

    public async Task UpdateProduct(Product productDto)
    {
        context.Products.Update(productDto);

        await context.SaveChangesAsync(true);
    }
}
