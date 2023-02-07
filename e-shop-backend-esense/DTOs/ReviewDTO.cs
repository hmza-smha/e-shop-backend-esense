using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.DTOs
{
    public class ReviewDTO
    {
        [Required]
        public string Username { get; set; }

        public int Rate { get; set; }

        public string Description { get; set; }

        [Required]
        public int ProductId { get; set; }
    }
}
