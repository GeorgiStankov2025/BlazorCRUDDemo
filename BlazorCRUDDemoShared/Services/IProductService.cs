using BlazorCRUDDemoShared.Data;
using BlazorCRUDDemoShared.Entity;

namespace BlazorCRUDDemo.Shared.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<Product> CreateProduct(Product product);

        Task<Product> GetProductById(int Id);

        Task<Product> UpdateProduct(int id,Product product);

        Task<bool> DeleteProduct(int id);

    }
}
