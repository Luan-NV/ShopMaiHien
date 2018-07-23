using AutoMapper;
using ShopMaiHien.Application.ViewModels.Product;
using ShopMaiHien.Data.Entities;

namespace ShopMaiHien.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}