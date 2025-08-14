using BlazorCRUDDemo.Shared.Services;
using BlazorCRUDDemoShared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUDDemo.Shared.Services
{
    public class ClientProductService : IProductService
    {

        private readonly HttpClient httpClient;

        public ClientProductService(HttpClient httpClient)
        {

            this.httpClient=httpClient;

        }

        public async Task<Product> CreateProduct(Product product)
        {

            var result = await httpClient.PostAsJsonAsync("/api/product", product);

            return await result.Content.ReadFromJsonAsync<Product>();

        }

        public async Task<Product> GetProductById(int Id)
        {

            var result = await httpClient.GetFromJsonAsync<Product>($"/api/product/{Id}");

            return result;

        }

        public async Task<bool> DeleteProduct(int id)
        {

            var result = await httpClient.DeleteAsync($"/api/product/{id}");

            return await result.Content.ReadFromJsonAsync<bool>();

        }

        public async Task<List<Product>> GetAllProducts()
        {
            
            throw new NotImplementedException();

        }

        public async Task<Product> UpdateProduct(int id, Product product)
        {
            var result = await httpClient.PutAsJsonAsync($"/api/product/{id}", product);


            return await result.Content.ReadFromJsonAsync<Product>(); 

        }

       
    }
}
