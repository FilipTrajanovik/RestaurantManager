using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Repository.Interfaces
{
    public interface IMenuRepository
    {
        Task<Menu?> GetMenuById(Guid id, Guid RestorauntId);
        void Update(Menu menu, Guid RestorauntId);
        void Delete(Menu menu, Guid RestorauntId);
        Task Add(Menu menu, Guid RestorauntId);
    }
}
