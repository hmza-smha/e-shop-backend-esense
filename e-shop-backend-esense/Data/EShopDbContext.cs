using e_shop_backend_esense.Models;
using Microsoft.EntityFrameworkCore;

namespace e_shop_backend_esense.Data
{
    public class EShopDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public EShopDbContext(DbContextOptions opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedCategories(builder);
            SeedCars(builder);
            SeedElectronics(builder);
    }

        private void SeedCategories(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Cars" },
                new Category() { Id = 11, Name = "BMW", ParentCategoryId = 1 },
                new Category() { Id = 12, Name = "Honda", ParentCategoryId = 1 },
                new Category() { Id = 13, Name = "Toyouta", ParentCategoryId = 1 },
                new Category() { Id = 14, Name = "Mercedes", ParentCategoryId = 1 },

                new Category() { Id = 23, Name = "Lexus", ParentCategoryId = 13 },

                new Category() { Id = 24, Name = "Maybach", ParentCategoryId = 14 },
                new Category() { Id = 25, Name = "Benz", ParentCategoryId = 14 },
                new Category() { Id = 26, Name = "AMG", ParentCategoryId = 14 },

                new Category() { Id = 2, Name = "Electronics" },
                new Category() { Id = 15, Name = "Laptops", ParentCategoryId = 2 },
                new Category() { Id = 17, Name = "Monitors", ParentCategoryId = 2 },
                new Category() { Id = 16, Name = "PC", ParentCategoryId = 2 },

                new Category() { Id = 27, Name = "HP", ParentCategoryId = 15 },
                new Category() { Id = 28, Name = "Acer", ParentCategoryId = 15 },
                new Category() { Id = 29, Name = "Dell", ParentCategoryId = 15 },

                new Category() { Id = 30, Name = "LG", ParentCategoryId = 17 },
                new Category() { Id = 31, Name = "Samsung", ParentCategoryId = 17 }
            );
        }

        private void SeedElectronics(ModelBuilder builder)
        {
            // Seed Electronics
            Product[] laptops = new Product[3];
            Product[] pc = new Product[3];
            Product[] monitors = new Product[3];
            Product[] dell = new Product[3];
            Product[] hp = new Product[3];
            Product[] acer = new Product[3];
            Product[] lg = new Product[3];
            Product[] samsung = new Product[3];
            int id = 90;

            for (var i = 0; i < 3; i++)
            {

                laptops[i] = new Product();
                pc[i] = new Product();
                monitors[i] = new Product();
                dell[i] = new Product();
                hp[i] = new Product();
                acer[i] = new Product();
                lg[i] = new Product();
                samsung[i] = new Product();

                laptops[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 15, // laptops Id
                    Name = "laptops " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                pc[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 16, // pc Id
                    Name = "pc " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(1, 6),
                    AdditionalInfo = "{}"
                };

                monitors[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 17, // monitors Id
                    Name = "monitors " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 200,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                dell[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 29, // dell Id
                    Name = "dell " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 250,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                hp[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 27, // hp Id
                    Name = "hp " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 400,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                acer[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 28, // acer Id
                    Name = "maybach " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 100,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                lg[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 30, // lg Id
                    Name = "lg " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 1500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                samsung[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 31, // samsung Id
                    Name = "samsung " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 1000,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };
            }

            builder.Entity<Product>().HasData(laptops);
            builder.Entity<Product>().HasData(pc);
            builder.Entity<Product>().HasData(hp);
            builder.Entity<Product>().HasData(dell);
            builder.Entity<Product>().HasData(acer);
            builder.Entity<Product>().HasData(lg);
            builder.Entity<Product>().HasData(samsung);
            builder.Entity<Product>().HasData(monitors);
        }

        private void SeedCars(ModelBuilder builder)
        {
            // Cars
            Product[] bmw = new Product[3];
            Product[] honda = new Product[3];
            Product[] toyota = new Product[3];
            Product[] mercedes = new Product[3];
            Product[] lexus = new Product[3];
            Product[] maybach = new Product[3];
            Product[] benz = new Product[3];
            Product[] amg = new Product[3];
            int id = 1;

            for (var i = 0; i < 3; i++)
            {

                bmw[i] = new Product();
                honda[i] = new Product();
                toyota[i] = new Product();
                mercedes[i] = new Product();
                lexus[i] = new Product();
                maybach[i] = new Product();
                benz[i] = new Product();
                amg[i] = new Product();

                bmw[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 11, // BMW Id
                    Name = "BMW " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice =50,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                honda[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 12, // BMW Id
                    Name = "honda " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                toyota[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 13, // toyota Id
                    Name = "toyota " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                mercedes[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 14, // BMW Id
                    Name = "mercedes " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                lexus[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 23, // lexus Id
                    Name = "lexus " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                maybach[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 24, // maybach Id
                    Name = "maybach " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                benz[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 25, // benz Id
                    Name = "benz " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };

                amg[i] = new Product
                {
                    Id = ++id,
                    CategoryId = 26, // amg Id
                    Name = "amg " + i,
                    ImageURL = "https://via.placeholder.com/600x800",
                    Description = "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.",
                    Price = GetRandomNumber(50, 500),
                    OldPrice = 500,
                    InStuck = GetRandomNumber(1, 10) > 5 ? true : false,
                    Available = GetRandomNumber(1, 10) > 5 ? true : false,
                    Rate = GetRandomNumber(0, 6),
                    AdditionalInfo = "{}"
                };
            }

            builder.Entity<Product>().HasData(bmw);
            builder.Entity<Product>().HasData(honda);
            builder.Entity<Product>().HasData(toyota);
            builder.Entity<Product>().HasData(mercedes);
            builder.Entity<Product>().HasData(lexus);
            builder.Entity<Product>().HasData(maybach);
            builder.Entity<Product>().HasData(benz);
            builder.Entity<Product>().HasData(amg);
        }

        private int GetRandomNumber(int from, int to)
        {
            Random rand = new Random();
            return rand.Next(from, to); // 0, 100 => returns random number between [0-100)
        }
    }
}
