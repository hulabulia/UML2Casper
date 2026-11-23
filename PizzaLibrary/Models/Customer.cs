using System;
using System.Collections.Generic;
using System.Text;


using PizzaLibrary.Interfaces;

namespace PizzaLibrary.Models
{
    public class Customer : ICustomer
    {
        private static int _nextId = 1;

        public string Address { get; set; }
        public bool ClubMember { get; set; }
        public int Id { get; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public Customer(string name, string mobile, string address)
        {
            Id = _nextId++;
            Name = name;
            Mobile = mobile;
            Address = address;
            ClubMember = false;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Mobile: {Mobile}, " +
                   $"Address: {Address}, ClubMember: {ClubMember}";
        }
    }
}
