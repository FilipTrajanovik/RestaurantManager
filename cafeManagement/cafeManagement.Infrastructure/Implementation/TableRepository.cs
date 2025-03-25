using cafeManagement.Repository.Interfaces;
using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Implementation
{
    public class TableRepository : ITableRepository
    {
        private readonly ApplicationContext _context;
        public TableRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Add(Table table, Guid RestorauntId)
        {
            await _context.Tables.AddAsync(table);
            
        }

        public void Delete(Table table, Guid RestorauntId)
        {
            _context.Tables.Remove(table);
        }

        public Task<List<Table>> GetAllTables(Guid RestorauntId)
        {
            return Task.FromResult(_context.Tables.ToList());
        }

        public Task<Table?> GetTableById(Guid id, Guid RestorauntId)
        {
            return Task.FromResult(_context.Tables.FirstOrDefault(x => x.id == id));
        }

        public void Update(Table table, Guid RestorauntId)
        {
            _context.Tables.Update(table);
        }
    }
}
