using e_shop_backend_esense.Migrations;
using e_shop_backend_esense.Models;
using Microsoft.EntityFrameworkCore;

namespace e_shop_backend_esense.Data
{
    public class EShopDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public EShopDbContext(DbContextOptions opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        //    var product1 = new Product
        //    {
        //        Name="product1",
                
        //    }

        //    builder.Entity<Category>().HasData(new Category()
        //    {
        //        Name = "Cat 1",
        //        Products
        //    })
        }
    }
}
