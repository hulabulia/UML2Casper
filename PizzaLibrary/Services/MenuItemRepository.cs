using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaLibrary.Data;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
namespace PizzaLibrary.Services
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private List<MenuItem> _menuItems;

        public MenuItemRepository()
        {
            _menuItems = new List<MenuItem>(MockData.MenuItemData);
        }

        public int Count
        {
            get { return _menuItems.Count; }
        }

        public List<MenuItem> GetAll()
        {
            return _menuItems;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            _menuItems.Add(menuItem);
        }

        public MenuItem GetMenuItemByNo(int no)
        {
            return _menuItems.FirstOrDefault(item => item.No == no)!;
        }

        public void RemoveMenuItem(int no)
        {
            MenuItem menuItem = GetMenuItemByNo(no);

            if (menuItem != null)
            {
                _menuItems.Remove(menuItem);
            }
        }

        public void PrintAllMenuItems()
        {
            foreach (MenuItem menuItem in _menuItems)
            {
                Console.WriteLine(menuItem);
            }
        }
    }
}
