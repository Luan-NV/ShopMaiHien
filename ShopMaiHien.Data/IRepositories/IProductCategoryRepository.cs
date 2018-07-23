using ShopMaiHien.Data.Entities;
using ShopMaiHien.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace ShopMaiHien.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}