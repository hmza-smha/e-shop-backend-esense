using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_shop_backend_esense.Repositories.Interfaces
{
    public interface IProduct
    {

        List<ProductDto> GetProducts(
            int? id,
            int? categoryId,
            bool? isInStock,
            bool? isAvailable,
            decimal? priceFrom,
            decimal? priceTo,
            string? sort,
            string? order
        );

        Task<ProductDto> AddProduct(ProductDto dto);

        Task DeleteProduct(int id);
    }
}
