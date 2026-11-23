using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace PizzaLibrary.Models
{
    public class MenuItem : IMenuItem
    {
        private static int _nextNo = 1;

        public string Description { get; set; }
        public string Name { get; set; }
        public int No { get; }
        public double Price { get; set; }
        public MenuType TheMenuType { get; set; }

        public MenuItem(
            string name,
            double price,
            string description,
            MenuType menuType)
        {
            No = _nextNo++;
            Name = name;
            Price = price;
            Description = description;
            TheMenuType = menuType;
        }

        public override string ToString()
        {
            return $"No: {No}, Name: {Name}, Price: {Price} kr, " +
                   $"Description: {Description}, Type: {TheMenuType}";
        }
    }
}
