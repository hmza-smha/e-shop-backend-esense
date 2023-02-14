using e_shop_backend_esense.Data;
using e_shop_backend_esense.Domain.Filters;
using e_shop_backend_esense.Dto;
using e_shop_backend_esense.Models;
using e_shop_backend_esense.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public ProductDto GetProduct(int id)
        {
            var product = _context.Products
            .Include(x => x.Reviews)
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
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

        public List<ProductDto> GetProducts(
            int? categoryId, 
            bool? isInStock, 
            bool? isAvailable, 
            decimal? priceFrom, 
            decimal? priceTo, 
            string? sort, 
            string? order)
        {
            if (categoryId == null) categoryId = 1;

            var childrenIds = _context.Categories
                .Where(x => x.ParentCategoryId == categoryId)
                .Select(x => x.Id)
                .ToList();

            childrenIds.Add((int)categoryId);

            if (isInStock == false)
                isInStock = null;

            if (isAvailable == false)
                isAvailable = null;

            var products = _context.Products
                .Where(p => childrenIds.Contains(p.CategoryId))
                .Where(p => isInStock != null ? p.IsInStock == isInStock : true)
                .Where(p => isAvailable != null ? p.IsAvailable == isAvailable : true)
                .Where(p => priceFrom != null ? p.Price >= priceFrom : true)
                .Where(p => priceTo != null ? p.Price <= priceTo : true)
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
                .ToList();


            if (sort?.ToUpper() == Sort.PRICE)
            {
                if (order?.ToUpper() == Order.DESC)
                    return products.OrderByDescending(x => x.Price).ToList();
                else
                    return products.OrderBy(x => x.Price).ToList();
            }
            else if (sort?.ToUpper() == Sort.NAME)
            {
                if (order?.ToUpper() == Order.DESC)
                    return products.OrderByDescending(x => x.Name).ToList();
                else
                    return products.OrderBy(x => x.Name).ToList();
            }
            else if (sort?.ToUpper() == Sort.RATE)
            {
                if (order?.ToUpper() == Order.DESC)
                    return products.OrderByDescending(x => x.Rate).ToList();
                else
                    return products.OrderBy(x => x.Rate).ToList();
            }

            return products.OrderByDescending(x => x.Rate).ToList();
        }
    }
}
