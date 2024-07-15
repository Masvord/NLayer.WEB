using AutoMapper;
using EcommerceMvc.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using NLayerPractice.Web.Services;

namespace EcommerceMvc.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryApiService _categoryApiService;
        private readonly IMapper _mapper;


        public CategoryController(CategoryApiService categoryApiService, IMapper mapper)
        {
            _categoryApiService = categoryApiService;
            _mapper = mapper;
        }


        [Route("getallcategories")]
        public async Task<IActionResult> Index()
        {
            var result = await _categoryApiService.GetAllAsync();
            var model = _mapper.Map<List<CategoryViewModel>>(result);
            return Json(model);
        }
    }
}
