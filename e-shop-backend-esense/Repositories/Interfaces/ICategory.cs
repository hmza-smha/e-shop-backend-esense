using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;

namespace e_shop_backend_esense.Repositories.Interfaces
{
    public interface ICategory
    {
        List<CategoryDto> GetCategory(int? id);

        Task AddCategory(CategoryDto dto);

        Task DeleteCategory(int id);

        Task UpdateCategory(CategoryDto dto, int id);
    }
}
