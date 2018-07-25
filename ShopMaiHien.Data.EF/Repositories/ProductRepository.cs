using System;
using System.Collections.Generic;
using System.Text;
using ShopMaiHien.Data.Entities;
using ShopMaiHien.Data.IRepositories;

namespace ShopMaiHien.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}