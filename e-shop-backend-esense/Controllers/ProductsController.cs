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


        [HttpPost]
        public IActionResult GetProducts([FromBody] Filters filters)
        {
            var products = _product.GetProducts(filters);

            return Ok(products);
        }

        [HttpPost("Add")]
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
