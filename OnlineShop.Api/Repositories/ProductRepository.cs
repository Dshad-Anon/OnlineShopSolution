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

        public async Task<ProductCategory> GetCategoriesById(int id)
        {
            var category = await this.onlineShopDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.onlineShopDbContext.Products.ToListAsync();

            return products;
        }
        public async Task<Product> GetProductById(int id)
        {
            var products = await this.onlineShopDbContext.Products.FindAsync(id);
            return products ;
        }
    }
}
