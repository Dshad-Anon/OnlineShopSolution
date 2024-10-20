using Microsoft.EntityFrameworkCore;
using OnlineShop.Api.Data;
using OnlineShop.Api.Entities;
using OnlineShop.Api.Repositories.Contracts;

namespace OnlineShop.Api.Repositories
{ 
    public class ProductRepository(OnlineShopDbContext onlineShopDbContext) : IProductRepository
    {
        private readonly OnlineShopDbContext onlineShopDbContext = onlineShopDbContext;

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.onlineShopDbContext.ProductCategories.ToListAsync();
            return categories;

        }

        public Task<ProductCategory> GetCategoriesById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.onlineShopDbContext.Products.ToListAsync();

            return products;
        }
        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
