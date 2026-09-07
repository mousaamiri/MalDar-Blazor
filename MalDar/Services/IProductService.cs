using MalDar.Models;

namespace MalDar.Services;

public interface IProductService
{
    Task<List<ProductItem>> GetAllProductsAsync();
    Task<ProductItem?> GetProductByIdAsync(int id);
    Task<ProductItem> AddProductAsync(AddProductRequest request);
    Task RemoveProductAsync(int id);
}
public class ProductService : IProductService
{
    private readonly List<ProductItem> _products =
    [
        new(1, "برنج", 850000),
        new(2, "روغن", 320000),
        new(3, "قند", 150000)
    ]; 
    public async Task<List<ProductItem>> GetAllProductsAsync()
    {
        
        await Task.Delay(500);
        return _products;
    }
    public async Task<ProductItem?> GetProductByIdAsync(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        await Task.Delay(300);
        return product;
    }
    public async Task<ProductItem> AddProductAsync(AddProductRequest request)
    {
        var newId = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;

        var product = new ProductItem(newId, request.Name, request.Price);
        _products.Add(product);
        await Task.Delay(200);
        return product;
    }
    public async Task RemoveProductAsync(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
        await Task.Delay(100);
    }
}