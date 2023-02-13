using e_shop_backend_esense.Data;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shop_backend_esense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly EShopDbContext _context;

        public CategoryController(EShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategory(int? id)
        {
            if(id == null)
            {
                var categories = await _context.Categories
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.ParentCategoryId
                })
                .ToListAsync();

                return Ok(categories);
            }

            var category = await _context.Categories
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.ParentCategoryId
                })
                .FirstOrDefaultAsync(x => x.Id == id);
                

            if (category == null)
                return NotFound();

            return Ok(category);
        }


        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var category = new Category
            {
                Name = dto.Name,
                ParentCategoryId = dto.ParentCategoryId
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                return NotFound();

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryDto dto, int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var category = await _context.Categories.FindAsync(id);

            if (category == null)
                return BadRequest();

            category.Name = dto.Name;
            category.ParentCategoryId = dto.ParentCategoryId;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return Ok(category);
        }

    }
}
