using AutoMapper;
using EcommerceMvc.WebUI.Models;
using NLayerPractice.Core.DTOs;

namespace EcommerceMvc.WebUI.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ProductWithCategoryDto, ProductWithCategoryViewModel>().ReverseMap();
            CreateMap<CategoryDto, CategoryViewModel>().ReverseMap();
            CreateMap<ProductDto, ProductViewModel>().ReverseMap();
        }

    }
}
