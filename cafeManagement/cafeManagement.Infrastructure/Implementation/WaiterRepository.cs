using cafeManagement.Repository.Interfaces;
using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Implementation
{
    public class WaiterRepository : IWaiterRepository
    {
        private readonly ApplicationContext _context;
        public WaiterRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Add(Waiter waiter, Guid RestorauntId)
        {
            await _context.Waiters.AddAsync(waiter);
        }

        public void Delete(Waiter waiter, Guid RestorauntId)
        {
            _context.Waiters.Remove(waiter);
        }

        public Task<List<Waiter>> GetAllWaiters(Guid RestorauntId)
        {
           return Task.FromResult(_context.Waiters.ToList());
        }

        public Task<Waiter?> GetWaiterById(Guid id, Guid RestorauntId)
        {
            return Task.FromResult(_context.Waiters.FirstOrDefault(x => x.id == id));
        }

        public void Update(Waiter waiter, Guid RestorauntId)
        {
            _context.Waiters.Update(waiter);
        }
    }
}
