using e_shop_backend_esense.Data;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using e_shop_backend_esense.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace e_shop_backend_esense.Repositories
{
    public class ReviewRepository : IReview
    {
        private readonly EShopDbContext _context;

        public ReviewRepository(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ReviewDto> AddReview(ReviewDto dto)
        {
            var review = new Review()
            {
                Username = dto.Username,
                Description = dto.Description,
                Rate = dto.Rate,
                ProductId = dto.ProductId
            };

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return dto;
        }

        public List<ReviewDto> GetProductReviews(int productId)
        {
            var reviews = _context.Reviews
                .Where(x => x.ProductId == productId)
                .Select(x => new ReviewDto
                {
                    Username = x.Username,
                    Rate = x.Rate,
                    Description = x.Description
                })
                .ToList();

            return reviews;
        }
    }
}
