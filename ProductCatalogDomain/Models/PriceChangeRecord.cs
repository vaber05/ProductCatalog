namespace ProductCatalogDomain.Models;

public class PriceChangeRecord
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public float NewPrice { get; set; }

    public float OldPrice { get; set; }

    public DateTime DateChanged { get; set; }
}
