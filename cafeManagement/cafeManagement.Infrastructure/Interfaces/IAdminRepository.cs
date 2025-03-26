using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Interfaces
{
    public interface IAdminRepository
    {
        Task<List<RestorauntManager>> GetAllRestorauntManagers();
        Task<RestorauntManager> Save(RestorauntManager restorauntManager);
    }
}
