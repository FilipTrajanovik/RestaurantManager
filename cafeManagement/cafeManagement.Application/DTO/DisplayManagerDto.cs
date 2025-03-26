using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Application.DTO
{
    public record DisplayManagerDto(Guid id, string? Username, string? RestorauntName, string? RestorauntLocation)
    {
        public static DisplayManagerDto from(RestorauntManager restorauntManager)
        {
            return new DisplayManagerDto(restorauntManager.id, restorauntManager.Username, restorauntManager.RestorauntName, restorauntManager.RestorauntLocation);
        }
        public RestorauntManager to(DisplayManagerDto displayManagerDto)
        {
            return new RestorauntManager
            {
                id = displayManagerDto.id,
                Username = displayManagerDto.Username,
                PasswordHash = "password",
                RestorauntName = displayManagerDto.RestorauntName,
                RestorauntLocation = displayManagerDto.RestorauntLocation
            };
        }
        public static List<DisplayManagerDto> fromList(List<RestorauntManager> restorauntManagers)
        {
            return restorauntManagers.Select(from).ToList();
        }
    }
}
