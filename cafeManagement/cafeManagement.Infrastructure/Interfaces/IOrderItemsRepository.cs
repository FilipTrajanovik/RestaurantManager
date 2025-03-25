using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Interfaces
{
    public interface IOrderItemsRepository
    {
        Task<OrderItem?> GetOrderItemById(Guid id, Guid RestorauntId);
        Task<List<OrderItem>> GetAllOrderItems(Guid RestorauntId);
        void Update(OrderItem orderItem, Guid RestorauntId);
        void Delete(OrderItem orderItem, Guid RestorauntId);
        Task Add(OrderItem orderItem, Guid RestorauntId);
    }
}
