using AutoMapper;
using EcommerceMvc.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using NLayerPractice.Web.Services;

namespace NLayerPractice.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductApiService _productApiService;
        private readonly IMapper _mapper;


        public ProductsController(ProductApiService productApiService, IMapper mapper)
        {
            _productApiService = productApiService;
            _mapper = mapper;
        }


        [Route("getallproducts")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productApiService.GetProductsWithCategoryAsync();
            var model = _mapper.Map<List<ProductWithCategoryViewModel>>(result);
            return Json(model);
        }


        [Route("getproductsbycategoryid/{categoryId}")]
        public IActionResult GetProductsByCategoryId(int categoryId)
        {
            var result = _productApiService.GetProductsByCategoryId(categoryId);
            var model = _mapper.Map<List<ProductViewModel>>(result);
            return Json(model);
        }

    }
}
