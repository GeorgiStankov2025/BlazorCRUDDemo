using BlazorCRUDDemo.Data;
using BlazorCRUDDemo.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDDemo.Services
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


    }
}
