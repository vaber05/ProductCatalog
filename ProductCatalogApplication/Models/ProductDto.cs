using System.ComponentModel.DataAnnotations;

namespace ProductCatalogApplication.Models;

public class ProductDto
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int SubcategoryId { get; set; }

    [MaxLength(10)]
    public string Code { get; set; } = string.Empty;

    public string? Name { get; set; }

    public string? Description { get; set; }

    [Range(0.0, double.MaxValue)]
    public float Price { get; set; }

    public float AvaragePriceHalfYear { get; set; }
}