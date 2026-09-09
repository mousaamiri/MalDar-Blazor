using System.Net.Http.Json;
using MalDar.UI.Models;

namespace MalDar.UI.Services;

public class ProductApiClient(HttpClient client)
{
    public async Task<List<ProductItem>> GetAllAsync()
    {
        return await client.GetFromJsonAsync<List<ProductItem>>("/api/products") ?? [];
    }

    public async Task<ProductItem?> GetByIdAsync(int id)
    {
        var response = await client.GetAsync($"/api/products/{id}");
        return response.IsSuccessStatusCode
            ? await response.Content.ReadFromJsonAsync<ProductItem>()
            : null;
    }

    public async Task<ProductItem?> AddAsync(AddProductRequest request)
    {
        var response = await client.PostAsJsonAsync("/api/products", request);
        return await response.Content.ReadFromJsonAsync<ProductItem>();
    }

    public async Task RemoveAsync(int id)
    {
        await client.DeleteAsync($"/api/products/{id}");
    }
}