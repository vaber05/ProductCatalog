using ProductCatalogDomain.Models;

namespace ProductCatalogApplication.Abstractions;

public interface ISubcategoryRepository
{
    Task CreateSubcategory(Subcategory subcategory);

    Task UpdateSubcategory(Subcategory subcategory);

    Task DeleteSubcategory(int id);

    Task<Subcategory> GetSubcategoryById(int id);
}
