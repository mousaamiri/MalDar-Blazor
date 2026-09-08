using MalDar.Models;
using MalDar.Services;

namespace MalDar.Endpoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/products");
        group.MapGet("/",async (IProductService productService) =>
        {
            var products = await productService.GetAllProductsAsync();
            return Results.Ok(products);
        });
        group.MapGet("/{id}", async (IProductService productService, int id) =>
        {
            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(product);
        });
        group.MapPost("/", async (IProductService productService, AddProductRequest product) =>
        {
            var item = await productService.AddProductAsync(product);
            return Results.Created($"/api/products/{item.Id}", item);
        });
        group.MapDelete("/{id}", async (IProductService productService, int id) =>
        {
            await productService.RemoveProductAsync(id);
            return Results.NoContent();
        });
    }
}