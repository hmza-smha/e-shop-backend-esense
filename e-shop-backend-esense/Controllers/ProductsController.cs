using e_shop_backend_esense.Data;
using e_shop_backend_esense.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("Tree")]
        public async Task<IActionResult> GetTree()
        {
            var cat = await _context.Categories
                .Include(x => x.SubCategories)
                .Where(x => x.ParentCategory == null)
                .Select(x => new
                {
                    x.Name,
                    children = x.SubCategories.Select(c => c.Name)
                })
                .ToListAsync();

            return Ok(cat);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string? categoryName)
        {
            if (categoryName == null)
                throw new NullReferenceException();

            var cat = await _context.Categories
                .Include(x => x.Products)
                .Include(x => x.SubCategories)
                .ThenInclude(x => x.Products)
                .Where(x => x.Name.ToLower() == categoryName.ToLower())
                .Select(x => new
                {
                    x.Name,
                    products = x.Products.Select(x => new
                    {
                        x.Id,
                        x.Name
                    }),
                    subProducts = x.SubCategories.Select(c => new
                    {
                        c.Name,
                        products = c.Products.Select(x => new
                        {
                            x.Id,
                            x.Name
                        })
                    })
                })
                .SingleOrDefaultAsync();

            return Ok(cat);
        }
    }
}
