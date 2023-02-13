using e_shop_backend_esense.Data;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace e_shop_backend_esense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EShopDbContext _context;

        public ProductsController(EShopDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetProducts(
            int? categoryId,
            bool? isInStock,
            bool? isAvailable,
            decimal? priceFrom,
            decimal? priceTo,
            string? sortby)
        {

            if (categoryId == null) categoryId = 1;

            var childrenIds = _context.Categories
                .Where(x => x.ParentCategoryId == categoryId)
                .Select(x => x.Id)
                .ToList();

            childrenIds.Add((int)categoryId);

            if (isInStock == false)
            {
                isInStock = null;
            }

            if (isAvailable == false)
            {
                isAvailable = null;
            }

            var products = _context.Products
                .Where(p => childrenIds.Contains(p.CategoryId))
                .Where(p => isInStock != null ? p.IsInStock == isInStock : true)
                .Where(p => isAvailable != null ? p.IsAvailable == isAvailable : true)
                .Where(p => priceFrom != null ? p.Price >= priceFrom : true)
                .Where(p => priceTo != null ? p.Price <= priceTo : true)
                //.OrderBy(p => p.Name)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Price,
                    p.IsInStock,
                    p.OldPrice,
                    p.ImageUrl,
                    p.IsAvailable,
                    p.Description,
                    p.AdditionalInfo,
                })
                .ToList();



            sortby = "price,des";
            var sortFilter = sortby.Split(",");


            if (sortFilter[0] == "price")
            {
                if (sortFilter[1] == "des")
                {
                    return Ok(products.OrderByDescending(x => x.Price));
                }
                else
                {
                    return Ok(products.OrderBy(x => x.Price));
                }
            }
            else if (sortFilter[0] == "name")
            {
                if (sortFilter[1] == "des")
                {
                    return Ok(products.OrderByDescending(x => x.Name));
                }
                else
                {
                    return Ok(products.OrderBy(x => x.Name));
                }

            }

            return Ok();

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int? id)
        {

            var product = await _context.Products
            //.Include(x => x.Reviews)
            .Where(p => p.Id == id)
            .Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                p.IsInStock,
                p.OldPrice,
                p.ImageUrl,
                p.IsAvailable,
                p.Description,
                p.AdditionalInfo,
                //p.Reviews

            })
            .FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var product = new Product
            {
                Name = dto.Name,
                ImageUrl = dto.ImageUrl,
                Description = dto.Description,
                AdditionalInfo = dto.Name,
                Price = dto.Price,
                OldPrice = dto.OldPrice,
                IsAvailable = dto.IsIsAvailable,
                IsInStock = dto.IsInStock,
                Rate = dto.Rate,
                CategoryId = dto.CategoryId
            };


            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
