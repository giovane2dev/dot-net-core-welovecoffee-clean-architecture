using AutoMapper;
using WeLoveCoffee.Application.DTOs;
using WeLoveCoffee.Domain.Entities;

namespace WeLoveCoffee.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}