using CafeManagement.Domain.Models;
using CafeManagement.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Implementation
{
    public class RestorauntManagerRepository : IRestorauntManagerRepository
    {
        private readonly ApplicationContext _context;

        public RestorauntManagerRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddAsync(RestorauntManager restorauntManager)
        {
            await _context.RestorauntManagers.AddAsync(restorauntManager);
        }

        public void Delete(RestorauntManager restorauntManager)
        {
             _context.RestorauntManagers.Remove(restorauntManager);
        }

        public async Task<List<RestorauntManager>> GetAllRestorauntManagers()
        {
            return await _context.RestorauntManagers.ToListAsync();
        }

        public async Task<RestorauntManager?> GetRestorauntManagerById(Guid id)
        {
            return await _context.RestorauntManagers.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }

        public void Update(RestorauntManager restorauntManager)
        {
            _context.Update(restorauntManager); 
        }
    }
}
