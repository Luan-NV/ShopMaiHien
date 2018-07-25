using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopMaiHien.Application.ViewModels.System;

namespace ShopMaiHien.Application.Interfaces
{
    public interface IFunctionService : IDisposable
    {
        Task<List<FunctionViewModel>> GetAll();

        List<FunctionViewModel> GetAllByPermission(Guid userId);
    }
}