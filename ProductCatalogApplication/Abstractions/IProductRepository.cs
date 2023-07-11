using ProductCatalogDomain.Models;

namespace ProductCatalogApplication.Abstractions;

public interface IProductRepository
{
    Task CreateProduct(Product productDto);

    Task DeleteProduct(int id);

    Task UpdateProduct(Product productDto);

    Task<Product> GetProductById(int id);

    Task<List<Product>> GetAllProducts();
}