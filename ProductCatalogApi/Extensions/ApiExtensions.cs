using Microsoft.EntityFrameworkCore;
using ProductCatalogApplication.Abstractions;
using ProductCatalogInfrastructure;
using ProductCatalogInfrastructure.Repositories;

namespace ProductCatalogApi.Extensions;

public static class ApiExtensions
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        var conectionString = builder.Configuration.GetConnectionString("ProductCatalogConectionString");
        builder.Services.AddDbContext<ProductCatalogDbContext>(opt => opt.UseSqlServer(conectionString));

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
    }

    public static void RegisterDependencyInjections(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<ISubcategoryRepository, SubcategoryRepository>();
        builder.Services.AddScoped<IPriceRecordRepository, PriceChangeRepository>();
    }
}
