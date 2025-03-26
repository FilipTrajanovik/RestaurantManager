using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Service.domain.Interfaces
{
    public interface IAdminService
    {
        Task<RestorauntManager> save(RestorauntManager restorauntManager);
        Task<List<RestorauntManager>> getAllRestorauntManagers();

    }
}
