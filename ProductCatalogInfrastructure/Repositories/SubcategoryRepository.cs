using Microsoft.EntityFrameworkCore;
using ProductCatalogApplication.Abstractions;
using ProductCatalogDomain.Models;

namespace ProductCatalogInfrastructure.Repositories;

public class SubcategoryRepository : ISubcategoryRepository
{
    private readonly ProductCatalogDbContext context;

    public SubcategoryRepository(ProductCatalogDbContext context)
    {
        this.context = context;
    }

    public async Task CreateSubcategory(Subcategory subcategory)
    {
        await context.Subcategories.AddAsync(subcategory);

        await context.SaveChangesAsync();
    }

    public async Task DeleteSubcategory(int id)
    {
        var subcategoryToDelete = await context.Subcategories.FirstOrDefaultAsync(s => s.Id == id);

        if(subcategoryToDelete is null)
            return;

        context.Subcategories.Remove(subcategoryToDelete);

        await context.SaveChangesAsync();
    }

    public async Task<Subcategory> GetSubcategoryById(int id)
    {
        return await context.Subcategories.FirstOrDefaultAsync(s => s.Id == id) ?? new();
    }

    public async Task UpdateSubcategory(Subcategory subcategory)
    {
        context.Subcategories.Update(subcategory);

        await context.SaveChangesAsync();
    }
}
