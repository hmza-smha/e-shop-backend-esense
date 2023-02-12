using e_shop_backend_esense.Models;
using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.Dto
{
    public class CategoryDto
    {

        [Required]
        public string Name { get; set; }
    }
}
