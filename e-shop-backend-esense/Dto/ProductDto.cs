using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.Dto
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }

        public string? ImageUrl { get; set; }

        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public decimal Price { get; set; }

        public decimal? OldPrice { get; set; }

        public bool IsInStock { get; set; }

        public bool IsIsAvailable { get; set; }

        public int? Rate { get; set; }

        [Required]
        public int CategoryId { get; set; }

    }
}
