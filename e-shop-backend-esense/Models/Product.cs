using System.ComponentModel.DataAnnotations;

namespace e_shop_backend_esense.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? ImageUrl { get; set; }

        public string? Description { get; set; }

        public string? AdditionalInfo { get; set; }

        public decimal Price { get; set; }

        public decimal? OldPrice { get; set; }
         
        public bool IsInStock { get; set; }

        public bool IsAvailable { get; set; }

        public int? Rate { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
