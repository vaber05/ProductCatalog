using Microsoft.EntityFrameworkCore;
using ProductCatalogApplication.Abstractions;
using ProductCatalogDomain.Models;

namespace ProductCatalogInfrastructure.Repositories;

public class PriceChangeRepository : IPriceRecordRepository
{
    private readonly ProductCatalogDbContext context;

    public PriceChangeRepository(ProductCatalogDbContext context)
    {
        this.context = context;
    }

    public async Task CreatePriceRecords(PriceChangeRecord record)
    {
        await context.PriceChangeRecords.AddAsync(record);

        await context.SaveChangesAsync();
    }

    public async Task DeleteOldPriceRecords(DateTime currentTime)
    {
        await context.PriceChangeRecords
            .Where(pcr => (currentTime - pcr.DateChanged).TotalDays > 182.625f)
            .ExecuteDeleteAsync();

        await context.SaveChangesAsync();
    }

    public async Task DeletePriceRecord(int id)
    {
        var priceRecordToDelete = await context.PriceChangeRecords.FirstOrDefaultAsync(pcr => pcr.Id == id);

        if(priceRecordToDelete is null)
            return;

        context.PriceChangeRecords.Remove(priceRecordToDelete);

        await context.SaveChangesAsync();
    }

    public async Task<List<PriceChangeRecord>> GetAllPriceRecords()
    {
        return await context.PriceChangeRecords.ToListAsync();
    }
}
