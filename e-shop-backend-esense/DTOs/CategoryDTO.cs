using e_shop_backend_esense.Models;
using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.DTOs
{
    public class CategoryDTO
    {

        [Required]
        public string Name { get; set; }
    }
}
