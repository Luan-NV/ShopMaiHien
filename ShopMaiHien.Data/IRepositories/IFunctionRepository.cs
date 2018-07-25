using System;
using System.Collections.Generic;
using System.Text;
using ShopMaiHien.Data.Entities;
using ShopMaiHien.Infrastructure.Interfaces;

namespace ShopMaiHien.Data.IRepositories
{
    public interface IFunctionRepository : IRepository<Function, string>
    {
    }
}