namespace ProductCatalogDomain.Models;

public class Subcategory
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public ICollection<Product> ProductsWithThisSubcategory { get; set; } = new List<Product>();
}
