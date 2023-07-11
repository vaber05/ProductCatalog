namespace ProductCatalogApplication.Models;

public class SubcategoryDto
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public ICollection<int> IdsOfProductsWithThisSubcategory { get; set; } = new List<int>();
}