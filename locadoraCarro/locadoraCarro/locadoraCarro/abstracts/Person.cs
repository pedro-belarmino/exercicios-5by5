using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using locadoraCarro.Models;

namespace locadoraCarro.abstracts
{
    public abstract class Person
    {
        public string? Name { get; set; }
        public DateOnly? BirthDate { get; set; }
        public Contact? Contact { get; set; }
        public Address? Address { get; set; }

        public Person (string n, DateOnly b, Contact c, Address a)
        {
            Name = n;
            BirthDate = b;
            Contact = c;
            Address = a;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Birthdate{BirthDate}, Contact {Contact}, Address {Address}";
        }

        internal void setContactPhone(string? phone)
        {
            Contact.setPhone(phone);
        }
    }
}