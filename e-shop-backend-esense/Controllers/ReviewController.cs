using e_shop_backend_esense.Data;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using e_shop_backend_esense.Repositories.Interfaces;
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
        private readonly IReview _review;


        public ReviewController(EShopDbContext context, IReview review)
        {
            _review = review;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddReview([FromBody] ReviewDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _review.AddReview(dto);

            return Ok(dto);
        }

        [HttpGet("{productId}")]
        public IActionResult GetProductReviews(int productId)
        {
            return Ok(_review.GetProductReviews(productId));
        }
    }
}
