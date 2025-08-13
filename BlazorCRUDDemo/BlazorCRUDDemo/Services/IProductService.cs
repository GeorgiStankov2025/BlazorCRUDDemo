using BlazorCRUDDemo.Data;
using BlazorCRUDDemo.Entity;

namespace BlazorCRUDDemo.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<Product> CreateProduct(Product product);

    }
}
