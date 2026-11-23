using PizzaLibrary.Models;
using System.Collections.Generic;
using PizzaLibrary.Services;

CustomerRepository customerRepo = new CustomerRepository();
MenuItemRepository menuRepo = new MenuItemRepository();

Console.WriteLine("===== KUNDER =====");
Console.WriteLine($"Antal kunder: {customerRepo.Count}");
customerRepo.PrintAllCustomers();

Console.WriteLine();

Console.WriteLine("===== MENU =====");
Console.WriteLine($"Antal menuitems: {menuRepo.Count}");
menuRepo.PrintAllMenuItems();


customerRepo.GetCustomerByMobile("12121212").ClubMember = true;


List<Customer> clubMembers = customerRepo.GetClubMembers();

Console.WriteLine("===== CLUB MEMBERS =====");

foreach (Customer customer in clubMembers)
{
    Console.WriteLine(customer);
}