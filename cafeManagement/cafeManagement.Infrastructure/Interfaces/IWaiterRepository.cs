using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Interfaces
{
    public interface IWaiterRepository
    {
        Task<Waiter?> GetWaiterById(Guid id, Guid RestorauntId);
        Task<List<Waiter>> GetAllWaiters(Guid RestorauntId);
        void Update(Waiter waiter, Guid RestorauntId);
        void Delete(Waiter waiter, Guid RestorauntId);
        Task Add(Waiter waiter, Guid RestorauntId);
    }
}
