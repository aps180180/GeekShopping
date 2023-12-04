using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string baseUrl = "api/v1/product";
        public ProductService(HttpClient client)
        {
                _client = client;
        }
        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response= await _client.GetAsync(baseUrl);
            return await response.ReadContentAsync<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _client.GetAsync($"{baseUrl}/{id}");
            return await response.ReadContentAsync<ProductModel>();
        }
        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _client.PostAsJson(baseUrl,model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAsync<ProductModel>();
            else
                throw new ApplicationException($"Ocorreu um erro chamando api: {response.ReasonPhrase} ");
        }
        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            var response = await _client.PutAsJson(baseUrl, model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAsync<ProductModel>();
            else
                throw new ApplicationException($"Ocorreu um erro chamando api: {response.ReasonPhrase} ");
        }
    
        public async Task<bool> DeleteProductById(long id)
        {
            var response = await _client.DeleteAsync($"{baseUrl}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAsync<bool>();
            else
                throw new ApplicationException($"Ocorreu um erro chamando api: {response.ReasonPhrase} ");

        }

        

        
    }
}
