using Microsoft.AspNetCore.Components;
using OnlineShop.Web.Services.Contracts;
using OnlineShopLibrary.Models.Dtos;

namespace OnlineShop.Web.Pages
{
    public class ProductsBase: ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set;}

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
       protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductByCategory()
        {
            return from product in Products
                   group product by product.CategoryId
                                into productCatGroup
                   orderby productCatGroup.Key
                   select productCatGroup;
        }

        protected string GetCategoryName(IGrouping<int, ProductDto> productCatGroup)
        {
            return productCatGroup.FirstOrDefault(pg => pg.CategoryId == productCatGroup.Key).CategoryName;
        }
    }
}
