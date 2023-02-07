using e_shop_backend_esense.Data;
using e_shop_backend_esense.DTOs;
using e_shop_backend_esense.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shop_backend_esense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly EShopDbContext _context;

        public ReviewController(EShopDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddReview([FromBody] ReviewDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var review = new Review()
            {
                Username = dto.Username,
                Description = dto.Description,
                Rate = dto.Rate,
                ProductId = dto.ProductId
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return Ok(review);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReview([FromBody] ReviewDTO dto, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var review = await _context.Reviews.FindAsync(id);

            if (review == null)
                return BadRequest();

            review.Description = dto.Description;
            review.Rate = dto.Rate;

            _context.Reviews.Update(review);
            await _context.SaveChangesAsync();

            return Ok(review);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductReviews(int productId)
        {
            var review = await _context.Reviews
                .Where(x => x.ProductId == productId)
                .ToListAsync();

            if (review == null)
                return NotFound();

            return Ok(review);
        }
    }
}
