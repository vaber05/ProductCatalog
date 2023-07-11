namespace ProductCatalogDomain.Models;

public class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public ICollection<Subcategory> Subcategories { get; set; } = new List<Subcategory>();

    public ICollection<Product> ProductsWithThisCategory { get; set; } = new List<Product>();
}
