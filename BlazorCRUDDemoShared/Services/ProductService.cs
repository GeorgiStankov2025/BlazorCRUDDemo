using BlazorCRUDDemoShared.Data;
using BlazorCRUDDemoShared.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDDemo.Shared.Services
{
    public class ProductService : IProductService
    {

        private readonly BlazorCRUDDemoDbContext Context;

        public ProductService(BlazorCRUDDemoDbContext context)
        {

            this.Context = context;

        }

        public async Task<List<Product>> GetAllProducts()
        {

            await Task.Delay(1000);

            var products= await Context.Products.ToListAsync();

            return products;

        }

        public async Task<Product> CreateProduct(Product product)
        {

            await Context.Products.AddAsync(product);

            await Context.SaveChangesAsync();

            return product;

        }

        public async Task<Product> GetProductById(int Id)
        {
            return await Context.Products.FindAsync(Id);
        }

        public async Task<Product> UpdateProduct(int id, Product product)
        {

            var productindatabase = await Context.Products.FindAsync(id);

            if (productindatabase != null)
            {
            
               productindatabase.Name=product.Name;

                await Context.SaveChangesAsync();

                return productindatabase;

            }

            throw new Exception("Item not found!");

        }

        public async Task<bool> DeleteProduct(int id)
        {
            
            var productindatabase= await Context.Products.FindAsync(id);

            if (productindatabase != null)
            {

                Context.Remove(productindatabase);

                await Context.SaveChangesAsync();

                return true;

            }

            return false;

        }
    }
}
