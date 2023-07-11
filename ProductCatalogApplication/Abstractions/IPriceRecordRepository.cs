using ProductCatalogDomain.Models;

namespace ProductCatalogApplication.Abstractions;

public interface IPriceRecordRepository
{
    Task<List<PriceChangeRecord>> GetAllPriceRecords();

    Task CreatePriceRecords(PriceChangeRecord record);

    Task DeleteOldPriceRecords(DateTime currentTime);

    Task DeletePriceRecord(int id);
}
