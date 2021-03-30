using SimpleExample.Domain;

namespace SimpleExample.WebApi.Models
{
    public class CustomerModel
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public byte Age { get; private set; }
        public CustomerModel(string firstName, string lastName, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public static implicit operator CustomerModel(Customer customer)
            => customer is null ? null : new CustomerModel(customer.FirstName, customer.LastName, customer.Age);
    }
}
