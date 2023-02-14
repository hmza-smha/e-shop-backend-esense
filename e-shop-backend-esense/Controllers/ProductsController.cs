using e_shop_backend_esense.Data;
using e_shop_backend_esense.Domain.Filters;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using e_shop_backend_esense.Repositories;
using e_shop_backend_esense.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace e_shop_backend_esense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProduct _product;

        public ProductsController(IProduct product)
        {
            _product = product;
        }


        [HttpGet]
        public IActionResult GetProducts(
            int? categoryId,
            bool? isInStock,
            bool? isAvailable,
            decimal? priceFrom,
            decimal? priceTo,
            string? sort,
            string? order)
        {
            var products = _product.GetProducts(
                categoryId, 
                isInStock, 
                isAvailable, 
                priceFrom, 
                priceTo, 
                sort, 
                order
                );

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(_product.GetProduct(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductDto dto)
        {
            if (!ModelState.IsValid) return BadRequest();

            try
            {
                await _product.AddProduct(dto);
            }
            catch(NullReferenceException ex)
            {
                return StatusCode(500, ex.Message);
            }

            return Ok(dto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                await _product.DeleteProduct(id);
            }
            catch (NullReferenceException ex)
            {
                return StatusCode(500, ex.Message);
            }

            return Ok();
        }

    }
}
