using Microsoft.EntityFrameworkCore;
using ProductCatalogApplication.Abstractions;
using ProductCatalogDomain.Models;

namespace ProductCatalogInfrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly ProductCatalogDbContext context;

    public CategoryRepository(ProductCatalogDbContext context)
    {
        this.context = context;
    }

    public async Task CreateCategory(Category category)
    {
        await context.Categories.AddAsync(category);
        await context.SaveChangesAsync();
    }

    public async Task DeleteCategory(int id)
    {
        var categoryToDelete = await context.Categories.FirstOrDefaultAsync(c => c.Id == id);

        if (categoryToDelete is null)
            return;

        context.Categories.Remove(categoryToDelete);

        await context.SaveChangesAsync();
    }

    public async Task<Category> GetCategoryById(int id)
    {
        return await context.Categories.Include(c => c.Subcategories)
            .FirstOrDefaultAsync(c => c.Id == id) ?? new();
    }

    public async Task UpdateCategory(Category categoryDto)
    {
        context.Categories.Update(categoryDto);

        await context.SaveChangesAsync();
    }
}
