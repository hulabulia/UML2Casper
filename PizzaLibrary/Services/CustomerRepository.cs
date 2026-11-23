using System;
using System.Collections.Generic;
using System.Text;
using PizzaLibrary.Data;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
namespace PizzaLibrary.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Dictionary<string, Customer> _customers;
        public CustomerRepository()
        {
            _customers = new Dictionary<string, Customer>(MockData.CustomerData);
        }

        public int Count
        {
            get { return _customers.Count; }
        }

        public List<Customer> GetAll()
        {
            return _customers.Values.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer.Mobile, customer);
        }

        public Customer GetCustomerByMobile(string mobile)
        {
            return _customers.TryGetValue(mobile, out Customer customer)
                ? customer
                : null!;
        }

        public void RemoveCustomer(string mobile)
        {
            _customers.Remove(mobile);
        }

        public void PrintAllCustomers()
        {
            foreach (Customer customer in _customers.Values)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
