using ProductCatalogApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices();
builder.RegisterDependencyInjections();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();