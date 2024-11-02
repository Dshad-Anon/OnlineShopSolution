using OnlineShop.Web.Services.Contracts;
using OnlineShopLibrary.Models.Dtos;
using System.Net.Http.Json;

namespace OnlineShop.Web.Services
{
    public class ProductService(HttpClient httpClient) : IProductService
    {
        private readonly HttpClient httpClient = httpClient;

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/Product");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProductDto>();
                    }
                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
                }
                else
                {
                    var message =  await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }         
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ProductDto> GetProduct(int id)
        {
            try
            {
                var response = await this.httpClient.GetAsync($"api/Product/{id}");
                if(response.IsSuccessStatusCode) 
                {   
                    if(response.StatusCode == System.Net.HttpStatusCode.NoContent) 
                    {
                        return default(ProductDto);
                    }
                    return await response.Content.ReadFromJsonAsync<ProductDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }
    }
}
