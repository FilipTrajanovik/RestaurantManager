using cafeManagement.Application.application.Interfaces;
using CafeManagement.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace cafeManagement.API.Controllers
{
    [ApiController]
    [Route("api/admin")]
    public class AdminController : Controller
    {
        private readonly IAdminAppService _adminAppService;

        public AdminController(IAdminAppService adminAppService)
        {
            _adminAppService = adminAppService;
        }

        [HttpGet("allManagers")]
        public async Task<IActionResult> GetAllManagers()
        {
            var managers = await _adminAppService.GetAllRestorauntManagers();
            return Ok(managers);
        }

        [HttpPost("create-manager")]
        public async Task<IActionResult> CreateManager([FromBody] CreateManagerDto createManagerDto)
        {
            var manager = await _adminAppService.Save(createManagerDto);
            return Ok(manager);
        }
    }
}
