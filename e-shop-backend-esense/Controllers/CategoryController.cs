using e_shop_backend_esense.Data;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using e_shop_backend_esense.Repositories;
using e_shop_backend_esense.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shop_backend_esense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }

        [HttpGet]
        public IActionResult GetCategory(int? id)
        {
            return Ok(_category.GetCategory(id));
        }


        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _category.AddCategory(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                await _category.DeleteCategory(id);
            }
            catch (NullReferenceException ex)
            {
                return StatusCode(500, ex.Message);
            }

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryDto dto, int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await _category.UpdateCategory(dto, id);
            }
            catch(NullReferenceException ex)
            {
                return StatusCode(500, ex.Message);
            }

            return Ok();
        }

    }
}
