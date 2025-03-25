using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order?> GetOrderById(Guid id, Guid RestorauntId);
        Task<List<Order>> GetAllOrders(Guid RestorauntId);
        void Update(Order order, Guid RestorauntId);
        void Delete(Order order, Guid RestorauntId);
        Task Add(Order order);
    }
}
