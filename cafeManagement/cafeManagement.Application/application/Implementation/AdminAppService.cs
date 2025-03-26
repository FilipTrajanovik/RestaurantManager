using cafeManagement.Application.application.Interfaces;
using cafeManagement.Application.DTO;
using cafeManagement.Service.domain.Implementation;
using cafeManagement.Service.domain.Interfaces;
using CafeManagement.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Application.application.Implementation
{
    public class AdminAppService : IAdminAppService
    {
        private readonly IAdminService _adminService;

        public AdminAppService(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public  async Task<List<DisplayManagerDto>> GetAllRestorauntManagers()
        {
            var managers =  await _adminService.getAllRestorauntManagers();
            return DisplayManagerDto.fromList(managers);
        }

        public async Task<DisplayManagerDto> Save(CreateManagerDto createManagerDto)
        {
            var manager = new CreateManagerDto(
                    createManagerDto.Username,
                    createManagerDto.PasswordHash,
                    createManagerDto.RestorauntName,
                    createManagerDto.RestorauntLocation

                ).to();
            var savedManager = await _adminService.save(manager);
            return DisplayManagerDto.from(savedManager);
        }
    }
}
