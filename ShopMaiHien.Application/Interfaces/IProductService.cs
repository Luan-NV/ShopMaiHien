using System;
using System.Collections.Generic;
using System.Text;
using ShopMaiHien.Application.ViewModels.Product;
using ShopMaiHien.Utilities.Dtos;

namespace ShopMaiHien.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}