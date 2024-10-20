using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Laptops" },
                    { 2, "Monitors" },
                    { 3, "Phones" },
                    { 4, "Watches" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Apple MacBook Pro 14-inch with M1 Pro chip, 16GB RAM, 512GB SSD", "/Images/Laptops/Laptop1.png", "MacBook Pro 14\"", 2000m, 30 },
                    { 2, 1, "Dell XPS 13 Laptop with Intel Core i7, 16GB RAM, 1TB SSD", "/Images/Laptops/Laptop2.png", "Dell XPS 13", 1500m, 25 },
                    { 3, 1, "HP Spectre x360 Convertible Laptop with Intel Core i5, 8GB RAM, 512GB SSD", "/Images/Laptops/Laptop3.png", "HP Spectre x360", 1200m, 50 },
                    { 4, 1, "Lenovo ThinkPad X1 Carbon, Intel Core i7, 16GB RAM, 1TB SSD", "/Images/Laptops/Laptop4.png", "Lenovo ThinkPad X1 Carbon", 1800m, 40 },
                    { 5, 2, "Dell UltraSharp 27-inch 4K Monitor with USB-C connectivity", "/Images/Monitors/Monitor1.png", "Dell UltraSharp 27\"", 600m, 60 },
                    { 6, 2, "Samsung Odyssey G7 32-inch Curved Gaming Monitor, 240Hz refresh rate", "/Images/Monitors/Monitor2.png", "Samsung Odyssey G7", 700m, 40 },
                    { 7, 2, "LG 34-inch UltraWide Monitor, 144Hz, with HDR support", "/Images/Monitors/Monitor3.png", "LG 34\" UltraWide", 800m, 35 },
                    { 8, 2, "Acer Predator 27-inch Gaming Monitor, 144Hz, with G-Sync", "/Images/Monitors/Monitor4.png", "Acer Predator 27\"", 550m, 70 },
                    { 9, 3, "Apple iPhone 14 Pro, 256GB, 6.1-inch display", "/Images/Phones/Phone1.png", "iPhone 14 Pro", 1100m, 100 },
                    { 10, 3, "Samsung Galaxy S23 Ultra, 512GB, 108MP camera", "/Images/Phones/Phone2.png", "Samsung Galaxy S23 Ultra", 1200m, 90 },
                    { 11, 3, "Google Pixel 8, 128GB, 6.3-inch OLED display", "/Images/Phones/Phone3.png", "Google Pixel 8", 800m, 85 },
                    { 12, 3, "OnePlus 11, 256GB, 50MP triple camera setup", "/Images/Phones/Phone4.png", "OnePlus 11", 900m, 60 },
                    { 13, 4, "Apple Watch Series 9 with GPS, 41mm, Space Gray", "/Images/Watches/Watch1.png", "Apple Watch Series 9", 400m, 120 },
                    { 14, 4, "Samsung Galaxy Watch 6, 44mm, with LTE support", "/Images/Watches/Watch2.png", "Samsung Galaxy Watch 6", 350m, 110 },
                    { 15, 4, "Garmin Fenix 7, Multisport GPS watch with heart rate monitor", "/Images/Watches/Watch3.png", "Garmin Fenix 7", 600m, 50 },
                    { 16, 4, "Fitbit Versa 4, Fitness and Health Tracker, 40mm", "/Images/Watches/Watch4.png", "Fitbit Versa 4", 250m, 150 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Alice" },
                    { 2, "John" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
