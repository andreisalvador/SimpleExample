using SimpleExample.Core;
using System;

namespace SimpleExample.Domain
{
    public class Customer : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public byte Age { get; private set; }
        public Customer(string firstName, string lastName, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;          
        }
    }
}
