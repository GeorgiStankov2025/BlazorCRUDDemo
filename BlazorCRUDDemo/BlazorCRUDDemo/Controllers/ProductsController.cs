using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorCRUDDemo.Shared.Services;
using BlazorCRUDDemoShared.Entity;

namespace BlazorCRUDDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {

            _productService = productService;

        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<Product>> GetProductById(int Id)
        {

            var product = await _productService.GetProductById(Id);

            return Ok(product);

        }

        [HttpPost]   

        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {

            var addedProduct = await _productService.CreateProduct(product);

            return Ok(addedProduct);

        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Product>> UpdateProduct(int id,Product product)
        {

            var updatedProduct= await _productService.UpdateProduct(id, product);

            return Ok(updatedProduct);

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {

            var result = await _productService.DeleteProduct(id);

            return Ok(result);

        }


    }
}
