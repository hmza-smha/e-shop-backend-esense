using e_shop_backend_esense.Dto;
using Microsoft.AspNetCore.Mvc;

namespace e_shop_backend_esense.Repositories.Interfaces
{
    public interface IReview
    {
        Task<ReviewDto> AddReview(ReviewDto dto);

        List<ReviewDto> GetProductReviews(int productId);
    }
}
