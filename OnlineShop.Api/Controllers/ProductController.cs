using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Api.Entities;
using OnlineShop.Api.Extensions;
using OnlineShop.Api.Repositories;
using OnlineShop.Api.Repositories.Contracts;
using OnlineShopLibrary.Models.Dtos;

namespace OnlineShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductRepository productRepository) : ControllerBase
    {
        private readonly IProductRepository productRepository = productRepository;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {

            try
            {
                var products = await this.productRepository.GetItems();
                var productsCategories = await this.productRepository.GetCategories();

                if(products == null || productsCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    // Linq the products and categories to get the producDto.
                    var productDtos = products.ConvertToDto(productsCategories);
                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError , "Error retrieving data from the database");
            }

        }
    }
}
