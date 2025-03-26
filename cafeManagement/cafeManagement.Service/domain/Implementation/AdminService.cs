using cafeManagement.Repository.Implementation;
using cafeManagement.Repository.Interfaces;
using cafeManagement.Service.domain.Interfaces;
using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Service.domain.Implementation
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Task<List<RestorauntManager>> getAllRestorauntManagers()
        {
            return _adminRepository.GetAllRestorauntManagers();
        }

        public async Task<RestorauntManager> save(RestorauntManager restorauntManager)
        {
            await _adminRepository.Save(restorauntManager);
            return restorauntManager;
        }
    }
}
