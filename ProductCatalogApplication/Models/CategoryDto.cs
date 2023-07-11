namespace ProductCatalogApplication.Models;

public class CategoryDto
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public ICollection<int> SubcategorieIds { get; set; } = new List<int>();

    public ICollection<int> IdsOfProductsWithThisCategory { get; set; } = new List<int>();
}