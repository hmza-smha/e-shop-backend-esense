﻿using e_shop_backend_esense.Data;
using e_shop_backend_esense.DTOs;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if(category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }


        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryDTO dto, int? parentCategoryId)
        {
            var category = new Category
            {
                Name = dto.Name,
                ParentCategoryId = parentCategoryId
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return Ok(category);
        }

        [HttpGet("Tree")]
        public async Task<IActionResult> GetCategoriesTree()
        {
            var tree = await _context.Categories
                        .Where(x => x.ParentCategoryId == null)
                        .Include(x => x.SubCategories)
                        .ThenInclude(x => x.SubCategories)
                        .Select(x => new
                        {
                            x.Name,
                            children = x.SubCategories.Select(x => new
                            {
                                x.Name,
                                children = x.SubCategories.Select(x => x.Name)
                            })
                        })
                        .ToListAsync();

            return Ok(tree);
        }

    }
}