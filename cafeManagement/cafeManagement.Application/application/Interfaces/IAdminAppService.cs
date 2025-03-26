using cafeManagement.Application.DTO;
using CafeManagement.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Application.application.Interfaces
{
    public interface IAdminAppService
    {
        Task<List<DisplayManagerDto>> GetAllRestorauntManagers();
        Task<DisplayManagerDto> Save(CreateManagerDto createManagerDto);
    }
}
