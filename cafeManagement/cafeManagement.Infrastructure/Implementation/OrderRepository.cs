using cafeManagement.Repository.Interfaces;
using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;

        public OrderRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(Order order)
        {
            await _context.Orders.AddAsync(order);
        }

        public void Delete(Order order, Guid RestorauntId)
        {
            _context.Orders.Remove(order);
        }

        public Task<List<Order>> GetAllOrders(Guid RestorauntId)
        {
            return Task.FromResult(_context.Orders.ToList());
        }

        public Task<Order?> GetOrderById(Guid id, Guid RestorauntId)
        {
            return Task.FromResult(_context.Orders.FirstOrDefault(x => x.id == id));
        }

        public void Update(Order order, Guid RestorauntId)
        {
             _context.Orders.Update(order);
        }
    }
}
