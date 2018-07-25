using System;
using System.Collections.Generic;
using System.Text;
using ShopMaiHien.Data.Entities;
using ShopMaiHien.Data.IRepositories;

namespace ShopMaiHien.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}