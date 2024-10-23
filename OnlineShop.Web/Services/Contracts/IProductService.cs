using OnlineShopLibrary.Models.Dtos;

namespace OnlineShop.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
