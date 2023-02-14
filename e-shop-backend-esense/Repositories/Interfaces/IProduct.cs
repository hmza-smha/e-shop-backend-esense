using e_shop_backend_esense.Domain.Filters;
using e_shop_backend_esense.Dto;

namespace e_shop_backend_esense.Repositories.Interfaces
{
    public interface IProduct
    {
        List<ProductDto> GetProducts(Filters filters);

        Task<ProductDto> AddProduct(ProductDto dto);

        Task DeleteProduct(int id);
    }
}
