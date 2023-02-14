using e_shop_backend_esense.Data;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using e_shop_backend_esense.Repositories.Interfaces;

namespace e_shop_backend_esense.Repositories
{
    public class CategoryRepository : ICategory
    {

        private readonly EShopDbContext _context;

        public CategoryRepository(EShopDbContext context)
        {
            _context = context;
        }

        public async Task AddCategory(CategoryDto dto)
        {
            var category = new Category
            {
                Name = dto.Name,
                ParentCategoryId = dto.ParentCategoryId
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null) throw new NullReferenceException();

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();;
        }

        public List<CategoryDto> GetCategory(int? id)
        {
            var categories = _context.Categories
            .Where(x => id != null ? x.Id == id : true)
            .Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                ParentCategoryId = c.ParentCategoryId
            })
            .ToList();

            return categories;
        }

        public async Task UpdateCategory(CategoryDto dto, int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null) throw new NullReferenceException();
                
            category.Name = dto.Name;
            category.ParentCategoryId = dto.ParentCategoryId;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
