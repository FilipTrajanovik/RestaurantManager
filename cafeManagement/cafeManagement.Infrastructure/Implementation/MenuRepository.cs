using CafeManagement.Domain.Models;
using CafeManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Implementation
{
    public class MenuRepository : IMenuRepository
    {
        private readonly ApplicationContext _context;
        public MenuRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Task Add(Menu menu, Guid RestorauntId)
        {
            var managerRestoraunt = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);
            if(managerRestoraunt != null)
            {
                 Task.FromResult(managerRestoraunt.Menu == menu);
                _context.SaveChanges();
            }
            throw new ArgumentNullException("No restoraunt with such an ID");
        }

        public void Delete(Menu menu, Guid RestorauntId)
        {
            var managerRestoraunt = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);
            if (managerRestoraunt != null)
            {
                managerRestoraunt.Menu = null;
                _context.SaveChanges();
            }
            throw new ArgumentNullException("No restoraunt with such an ID");
        }

        public Task<Menu?> GetMenuById(Guid id, Guid RestorauntId)
        {
            var managerRestoraunt = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);
            if (managerRestoraunt != null)
            {
                Task.FromResult(managerRestoraunt.Menu.id == id);    
            }
            throw new ArgumentNullException("No restoraunt with such an ID");
        }

        public void Update(Menu menu, Guid RestorauntId)
        {
            var managerRestoraunt = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);
            if (managerRestoraunt != null)
            {
                managerRestoraunt.Menu.RestorauntManager = menu.RestorauntManager;
                managerRestoraunt.Menu.RestorauntManagerId = menu.RestorauntManagerId;
                managerRestoraunt.Menu.MenuItems = menu.MenuItems;
                _context.SaveChanges();
            }
            throw new ArgumentNullException("No restoraunt with such an ID");
        }
    }
}
