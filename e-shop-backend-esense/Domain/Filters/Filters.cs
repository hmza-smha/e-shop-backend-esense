namespace e_shop_backend_esense.Domain.Filters
{
    public class Filters
    {
        public int? Id { get; set; }

        public int? CategoryId { get; set; }

        public bool? IsAvailable { get; set; }
        public bool? IsInStock { get; set; }

        public decimal? PriceFrom { get; set; }

        public decimal? PriceTo { get; set; }

        public string? Sort { get; set; }

        public string? Order { get; set; }

        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
