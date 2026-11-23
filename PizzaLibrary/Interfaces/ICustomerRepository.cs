using System;
using System.Collections.Generic;
using System.Text;
using PizzaLibrary.Models;
namespace PizzaLibrary.Interfaces
{
    public interface ICustomerRepository
    {
        int Count { get; }
        List<Customer> GetAll();
        void AddCustomer(Customer customer);
        Customer GetCustomerByMobile(string mobile);
        void RemoveCustomer(string mobile);
        void PrintAllCustomers();
    }
}
