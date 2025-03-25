using cafeManagement.Repository.Interfaces;
using CafeManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Implementation
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationContext _context;
        public AdminRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<RestorauntManager>> GetAllRestorauntManagers()
        {
            return await _context.RestorauntManagers.ToListAsync();
        }
    }
}
