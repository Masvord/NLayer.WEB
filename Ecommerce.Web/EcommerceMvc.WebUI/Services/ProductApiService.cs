using NLayerPractice.Core.DTOs;
using NLayerPractice.Core.DTOs.CustomDTOs;

namespace NLayerPractice.Web.Services
{
    ////Take product information
    public class ProductApiService
    {
        private readonly HttpClient _httpClient;

        public ProductApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductWithCategoryDto>> GetProductsWithCategoryAsync()
        {
            //I don't use full url because ı indicated "BaseURL" in appsettings.json
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductWithCategoryDto>>>("products/getproductswithcategory");

            return response.Data;
        }

        public List<ProductDto> GetProductsByCategoryId(int categoryId)
        {
            var response = _httpClient.GetFromJsonAsync<CustomResponseDto<List<ProductDto>>>($"products/getproductsbycategoryid/{categoryId}").GetAwaiter().GetResult();

            return response.Data;
        }

    }
}
