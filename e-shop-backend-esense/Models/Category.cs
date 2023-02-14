using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public int? ParentCategoryId { get; set; }

        public Category? ParentCategory { get; set; }

        //public List<Category> SubCategories { get; set; }
    }
}
