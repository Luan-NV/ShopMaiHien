using System;
using System.Collections.Generic;
using System.Text;
using ShopMaiHien.Application.ViewModels.Product;

namespace ShopMaiHien.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
    }
}