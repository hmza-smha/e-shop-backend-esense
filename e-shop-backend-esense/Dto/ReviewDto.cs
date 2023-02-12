using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.Dto
{
    public class ReviewDto
    {
        [Required]
        public string Username { get; set; }

        public int Rate { get; set; }

        public string Description { get; set; }

        [Required]
        public int ProductId { get; set; }
    }
}
