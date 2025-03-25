using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Repository.Interfaces
{
    public interface IRestorauntManagerRepository
    {
        Task<RestorauntManager?> GetRestorauntManagerById(Guid id);
        Task<List<RestorauntManager>> GetAllRestorauntManagers();
        Task AddAsync(RestorauntManager restorauntManager);
        void Update(RestorauntManager restorauntManager);
        void Delete(RestorauntManager restorauntManager);
        Task SaveChangesAsync();
    }
}
