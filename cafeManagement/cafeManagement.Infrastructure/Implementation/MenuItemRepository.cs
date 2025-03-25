using cafeManagement.Repository.Interfaces;
using CafeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeManagement.Repository.Implementation
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly ApplicationContext _context;
        public MenuItemRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Add(MenuItem menuItem, Guid RestorauntId)
        {
            var managerRestaurant = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);
            if (managerRestaurant != null)
            {
                managerRestaurant.Menu.MenuItems.Add(menuItem);
                await _context.SaveChangesAsync();

            }
            throw new ArgumentNullException("No Restoraunt with such an ID");


        }

        public void Delete(MenuItem menuItem, Guid RestorauntId)
        {
            var managerRestaurant = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);
            if (managerRestaurant != null)
            {
                managerRestaurant.Menu.MenuItems.Remove(menuItem);
                 _context.SaveChangesAsync();
            }
          
        }

        public List<MenuItem> GetAllMenuItems(Guid RestorauntId)
        {
            var managerRestaurant = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);
            if (managerRestaurant != null)
            {
                return managerRestaurant.Menu.MenuItems;
            }
            throw new ArgumentNullException("No Restoraunt with such an ID or menu does not exist");

        }

        public Task<MenuItem?> GetMenuItemById(Guid id, Guid RestorauntId)
        {
            var managerRestaurant = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);
            if (managerRestaurant != null)
            {
                 return Task.FromResult(managerRestaurant.Menu.MenuItems.FirstOrDefault(x => x.id == id));
                
            }
            throw new ArgumentNullException("No Restoraunt with such an ID or menu does not exist");

        }

        public void Update(MenuItem menuItem, Guid RestorauntId)
        {
            var managerRestaurant = _context.RestorauntManagers.FirstOrDefault(x => x.id == RestorauntId);

            if (managerRestaurant == null || managerRestaurant.Menu == null)
            {
                throw new ArgumentNullException("Restaurant or Menu not found");
            }

            var existingItem = managerRestaurant.Menu.MenuItems.FirstOrDefault(x => x.id == menuItem.id);
            if (managerRestaurant != null)
            {
                existingItem.Menu = menuItem.Menu;
                existingItem.Name = menuItem.Name;
                existingItem.Price = menuItem.Price;
                existingItem.Tables = menuItem.Tables;
                existingItem.Category = menuItem.Category;
                existingItem.Description = menuItem.Description;
                _context.SaveChangesAsync();

            }
            throw new ArgumentNullException("No Restoraunt with such an ID or menu does not exist");
        }
    }
}
