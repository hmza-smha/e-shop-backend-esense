using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.Dto
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }

        public string? ImageURL { get; set; }

        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public decimal Price { get; set; }

        public decimal? OldPrice { get; set; }

        public bool InStuck { get; set; }

        public bool Available { get; set; }

        public int? Rate { get; set; }

        [Required]
        public int CategoryId { get; set; }

    }
}
