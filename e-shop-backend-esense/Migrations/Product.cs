using e_shop_backend_esense.Models;

namespace e_shop_backend_esense.Migrations
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
