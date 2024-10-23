using Microsoft.AspNetCore.Components;
using OnlineShopLibrary.Models.Dtos;

namespace OnlineShop.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }

    }
}
