using AutoMapper;
using ShopMaiHien.Application.ViewModels.Product;
using ShopMaiHien.Application.ViewModels.System;
using ShopMaiHien.Data.Entities;

namespace ShopMaiHien.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
        }
    }
}