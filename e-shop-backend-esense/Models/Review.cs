using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        public int Rate { get; set; }

        public string Description { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
