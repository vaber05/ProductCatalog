using System.ComponentModel.DataAnnotations;

namespace ProductCatalogDomain.Models;

public class Product
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public int SubcategoryId { get; set; }

    [MaxLength(10)]
    public string Code { get; set; } = string.Empty;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public float Price { get; set; }

    public float AvaragePriceHalfYear { get; set; }

    public DateTime AvaragePriceHalfYearLastUpdate { get; set; }

    public string? UserLastUpdate { get; set; }

    public ICollection<PriceChangeRecord> PriceUpdates { get; set; } = new List<PriceChangeRecord>();
}