using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Interfaces
{
    public interface IMenuItemRepository
    {
        Task<MenuItem?> GetMenuItemById(Guid id, Guid RestorauntId);
        List<MenuItem> GetAllMenuItems(Guid RestorauntId);
        void Update(MenuItem menuItem, Guid RestorauntId);
        void Delete(MenuItem menuItem, Guid RestorauntId);
        Task Add(MenuItem menuItem, Guid RestorauntId);
    }
}
