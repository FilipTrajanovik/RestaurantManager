using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Application.DTO
{
    public record CreateManagerDto(string? Username, string? PasswordHash, string? RestorauntName, string? RestorauntLocation)
    {
        public static CreateManagerDto from(RestorauntManager restorauntManager)
        {
            return new CreateManagerDto(restorauntManager.Username, restorauntManager.PasswordHash, restorauntManager.RestorauntName, restorauntManager.RestorauntLocation);
        }
        public RestorauntManager to()
        {
            return new RestorauntManager
            {
                id = Guid.NewGuid(),
                Username = Username,
                PasswordHash = PasswordHash,
                RestorauntName = RestorauntName,
                RestorauntLocation = RestorauntLocation,
                Menu = new Menu(),
                Tables = new List<Table>(),
                Waiters = new List<Waiter>()
            };
        }
        public static List<CreateManagerDto> fromList(List<RestorauntManager> restorauntManagers)
        {
            return restorauntManagers.Select(from).ToList();
        }
    }
}
