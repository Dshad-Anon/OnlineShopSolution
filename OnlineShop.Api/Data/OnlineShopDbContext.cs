using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OnlineShop.Api.Entities;

namespace OnlineShop.Api.Data
{
    public class OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(product => product.Price).HasPrecision(8, 2);
            base.OnModelCreating(modelBuilder);
            
            // Products
            // Laptops Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "MacBook Pro 14\"",
                Description = "Apple MacBook Pro 14-inch with M1 Pro chip, 16GB RAM, 512GB SSD",
                ImageURL = "/Images/Laptops/Laptop1.png",
                Price = 2000M,
                Quantity = 30,
                CategoryId = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Dell XPS 13",
                Description = "Dell XPS 13 Laptop with Intel Core i7, 16GB RAM, 1TB SSD",
                ImageURL = "/Images/Laptops/Laptop2.png",
                Price = 1500M,
                Quantity = 25,
                CategoryId = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "HP Spectre x360",
                Description = "HP Spectre x360 Convertible Laptop with Intel Core i5, 8GB RAM, 512GB SSD",
                ImageURL = "/Images/Laptops/Laptop3.png",
                Price = 1200M,
                Quantity = 50,
                CategoryId = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Lenovo ThinkPad X1 Carbon",
                Description = "Lenovo ThinkPad X1 Carbon, Intel Core i7, 16GB RAM, 1TB SSD",
                ImageURL = "/Images/Laptops/Laptop4.png",
                Price = 1800M,
                Quantity = 40,
                CategoryId = 1
            });

            // Monitors Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Dell UltraSharp 27\"",
                Description = "Dell UltraSharp 27-inch 4K Monitor with USB-C connectivity",
                ImageURL = "/Images/Monitors/Monitor1.png",
                Price = 600M,
                Quantity = 60,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Samsung Odyssey G7",
                Description = "Samsung Odyssey G7 32-inch Curved Gaming Monitor, 240Hz refresh rate",
                ImageURL = "/Images/Monitors/Monitor2.png",
                Price = 700M,
                Quantity = 40,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "LG 34\" UltraWide",
                Description = "LG 34-inch UltraWide Monitor, 144Hz, with HDR support",
                ImageURL = "/Images/Monitors/Monitor3.png",
                Price = 800,
                Quantity = 35,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Acer Predator 27\"",
                Description = "Acer Predator 27-inch Gaming Monitor, 144Hz, with G-Sync",
                ImageURL = "/Images/Monitors/Monitor4.png",
                Price = 550,
                Quantity = 70,
                CategoryId = 2
            });

            // Phones Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "iPhone 14 Pro",
                Description = "Apple iPhone 14 Pro, 256GB, 6.1-inch display",
                ImageURL = "/Images/Phones/Phone1.png",
                Price = 1100,
                Quantity = 100,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Samsung Galaxy S23 Ultra",
                Description = "Samsung Galaxy S23 Ultra, 512GB, 108MP camera",
                ImageURL = "/Images/Phones/Phone2.png",
                Price = 1200,
                Quantity = 90,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Google Pixel 8",
                Description = "Google Pixel 8, 128GB, 6.3-inch OLED display",
                ImageURL = "/Images/Phones/Phone3.png",
                Price = 800,
                Quantity = 85,
                CategoryId = 3
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "OnePlus 11",
                Description = "OnePlus 11, 256GB, 50MP triple camera setup",
                ImageURL = "/Images/Phones/Phone4.png",
                Price = 900,
                Quantity = 60,
                CategoryId = 3
            });

            // Watches Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Apple Watch Series 9",
                Description = "Apple Watch Series 9 with GPS, 41mm, Space Gray",
                ImageURL = "/Images/Watches/Watch1.png",
                Price = 400,
                Quantity = 120,
                CategoryId = 4
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Samsung Galaxy Watch 6",
                Description = "Samsung Galaxy Watch 6, 44mm, with LTE support",
                ImageURL = "/Images/Watches/Watch2.png",
                Price = 350,
                Quantity = 110,
                CategoryId = 4
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Garmin Fenix 7",
                Description = "Garmin Fenix 7, Multisport GPS watch with heart rate monitor",
                ImageURL = "/Images/Watches/Watch3.png",
                Price = 600,
                Quantity = 50,
                CategoryId = 4
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Fitbit Versa 4",
                Description = "Fitbit Versa 4, Fitness and Health Tracker, 40mm",
                ImageURL = "/Images/Watches/Watch4.png",
                Price = 250,
                Quantity = 150,
                CategoryId = 4
            });

            // Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Alice"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "John"
            });

            // Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1
            });

            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2
            });

            // Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Laptops"
            });

            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Monitors"
            });

            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Phones"
            });

            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Watches"
            });



        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
  

    }
}
