using e_shop_backend_esense.Models;
using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? ParentCategoryId { get; set; }
    }
}
