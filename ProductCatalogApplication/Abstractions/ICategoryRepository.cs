using ProductCatalogDomain.Models;

namespace ProductCatalogApplication.Abstractions;

public interface ICategoryRepository
{
    Task CreateCategory(Category categoryDto);

    Task UpdateCategory(Category categoryDto);

    Task DeleteCategory(int id);

    Task<Category> GetCategoryById(int id);
}
