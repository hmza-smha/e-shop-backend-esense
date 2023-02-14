using e_shop_backend_esense.Data;
using e_shop_backend_esense.Domain.Filters;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using e_shop_backend_esense.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;


namespace e_shop_backend_esense.Repositories
{
    public class ProductRepository : IProduct
    {

        private readonly EShopDbContext _context;

        public ProductRepository(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ProductDto> AddProduct(ProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                ImageUrl = dto.ImageUrl,
                Description = dto.Description,
                AdditionalInfo = dto.Name,
                Price = dto.Price,
                OldPrice = dto.OldPrice,
                IsAvailable = dto.IsAvailable,
                IsInStock = dto.IsInStock,
                Rate = dto.Rate,
                CategoryId = dto.CategoryId
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return dto;
        }

        public async Task DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null) throw new NullReferenceException();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public List<ProductDto> GetProducts(Filters filters)
        {

            if (filters.Id != null)
            {
                var product = GetProduct(filters.Id);
                return new List<ProductDto> { product };
            }

            if (filters.CategoryId == null) filters.CategoryId = 1;
            if (filters.Sort == null) filters.Sort = Sort.RATE;
            if (filters.Order == null) filters.Order = Order.DESC;

            var childrenIds = _context.Categories
                .Where(x => x.ParentCategoryId == filters.CategoryId)
                .Select(x => x.Id)
                .ToList();

            childrenIds.Add((int)filters.CategoryId);

            if (filters.IsInStock == false)
                filters.IsInStock = null;

            if (filters.IsAvailable == false)
                filters.IsAvailable = null;

            var products = _context.Products
                .Where(p => childrenIds.Contains(p.CategoryId))
                .Where(p => filters.IsInStock != null ? p.IsInStock == filters.IsInStock : true)
                .Where(p => filters.IsAvailable != null ? p.IsAvailable == filters.IsAvailable : true)
                .Where(p => filters.PriceFrom != null ? p.Price >= filters.PriceFrom : true)
                .Where(p => filters.PriceTo != null ? p.Price <= filters.PriceTo : true)
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Rate = p.Rate,
                    IsInStock = p.IsInStock,
                    OldPrice = p.OldPrice,
                    ImageUrl = p.ImageUrl,
                    IsAvailable = p.IsAvailable,
                    Description = p.Description,
                    AdditionalInfo = p.AdditionalInfo,
                })
                .OrderBy(filters.Sort + " " + filters.Order)
                .ToList();

            return products;
        }


        private ProductDto GetProduct(int? id)
        {
            var product = _context.Products
            .Include(x => x.Reviews)
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Rate = p.Rate,
                IsInStock = p.IsInStock,
                OldPrice = p.OldPrice,
                ImageUrl = p.ImageUrl,
                IsAvailable = p.IsAvailable,
                Description = p.Description,
                AdditionalInfo = p.AdditionalInfo,
                Reviews = p.Reviews

            })
            .FirstOrDefault(x => x.Id == id);

            if (product == null) throw new NullReferenceException();

            return product;
        }

    }
}
