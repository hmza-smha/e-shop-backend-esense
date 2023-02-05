using e_shop_backend_esense.Data;
using e_shop_backend_esense.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            var catergoriesTree = await _context.Categories
                .Include(x => x.SubCategories)
                .Where(x => x.ParentCategory == null)
                .Select(x => new
                {
                    x.Name,
                    children = x.SubCategories.Select(c => new
                    {
                        c.Name,
                        children = c.SubCategories.Select(c => c.Name)
                    })
                })
                .ToListAsync();

            return Ok(catergoriesTree);
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(
            string? categoryName, 
            string? textSearch, 
            bool? inStuck, 
            bool? available, 
            decimal? priceFrom,
            decimal? priceTo
            ) {

            if (categoryName == null)
                categoryName = "cars";

            var cat = await _context.Categories
                .Include(x => x.Products)
                .Include(x => x.SubCategories)
                .ThenInclude(x => x.Products)
                .Where(x => x.Name.ToLower() == categoryName.ToLower())
                .Select(x => new
                {
                    x.Name,
                    products = x.Products
                    .Where(x => textSearch != null ? x.Name.Contains(textSearch) : true)
                    .Where(x => inStuck != null ? x.InStuck == inStuck : true)
                    .Where(x => available !=  null ? x.Available == available : true)
                    .Where(x => priceFrom != null ? x.Price >= priceFrom : x.Price >= 1)
                    .Where(x => priceTo != null ? x.Price <= priceTo : true)
                    .Select(x => new
                    {
                        x.Id,
                        x.Name,
                        x.Price,
                        x.InStuck,
                        x.OldPrice,
                        x.ImageURL,
                        x.Available,
                        x.Description,
                        x.AdditionalInfo,
                        x.Reviews
                    }),
                    subProducts = x.SubCategories.Select(c => new
                    {
                        c.Name,
                        products = c.Products
                        .Where(x => textSearch != null ? x.Name.Contains(textSearch) : true)
                        .Where(x => inStuck != null ? x.InStuck == inStuck : true)
                        .Where(x => available != null ? x.Available == available : true)
                        .Where(x => priceFrom != null ? x.Price >= priceFrom : x.Price >= 1)
                        .Where(x => priceTo != null ? x.Price <= priceTo : true)
                        .Select(x => new
                        {
                            x.Id,
                            x.Name,
                            x.Price,
                            x.InStuck,
                            x.OldPrice,
                            x.ImageURL,
                            x.Available,
                            x.Description,
                            x.AdditionalInfo,
                            x.Reviews
                        }),
                        subProducts = c.SubCategories.Select(c => new
                        {
                            c.Name,
                            products = c.Products
                            .Where(x => textSearch != null ? x.Name.Contains(textSearch) : true)
                            .Where(x => inStuck != null ? x.InStuck == inStuck : true)
                            .Where(x => available != null ? x.Available == available : true)
                            .Where(x => priceFrom != null ? x.Price >= priceFrom : x.Price >= 1)
                            .Where(x => priceTo != null ? x.Price <= priceTo : true)
                            .Select(x => new
                            {
                                x.Id,
                                x.Name,
                                x.Price,
                                x.InStuck,
                                x.OldPrice,
                                x.ImageURL,
                                x.Available,
                                x.Description,
                                x.AdditionalInfo,
                                x.Reviews
                            })
                        })
                    })
                })
                .SingleOrDefaultAsync();

            return Ok(cat);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(x => x.Category)
                .Include(x => x.Reviews)
                .SingleOrDefaultAsync(x => x.Id == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }


        private Product ProductFactory(Product product)
        {
            return new Product
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                OldPrice = product.OldPrice,
                InStuck = product.InStuck,
                Available = product.Available,
                ImageURL = product.ImageURL,
                Description = product.Description,
                AdditionalInfo = product.AdditionalInfo
            };
        }

    }
}
