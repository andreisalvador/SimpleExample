using SimpleExample.Domain;
using System;

namespace SimpleExample.WebApi.Models
{
    public class CustomerModel
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public byte Age { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public CustomerModel(string firstName, string lastName, byte age, DateTime createdAt)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            CreatedAt = createdAt;
        }

        public static implicit operator CustomerModel(Customer customer)
            => customer is null ? null : new CustomerModel(customer.FirstName, customer.LastName, customer.Age, customer.CreatedAt);
    }
}
