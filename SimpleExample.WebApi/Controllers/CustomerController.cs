using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleExample.Core.Data;
using SimpleExample.Domain;
using SimpleExample.WebApi.Models;
using System;
using System.Threading.Tasks;

namespace SimpleExample.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IRepository<Customer> _customerRepository;

        public CustomerController(ILogger<CustomerController> logger, IRepository<Customer> customerRepository)
        {
            _logger = logger;
            _customerRepository = customerRepository;
        }

        [HttpPost]
        public async void AddCustomer(CustomerModel customerModel)
        {
            Customer newCustomer = new Customer(customerModel.FirstName, customerModel.LastName, customerModel.Age);
            _customerRepository.Add(newCustomer);
            Ok(await _customerRepository.Save());
        }

        [HttpDelete("{customerId:guid}")]
        public async void DeleteCustomer(Guid customerId)
        {
            _customerRepository.Delete(await _customerRepository.Get(customerId));
            Ok(await _customerRepository.Save());
        }

        [HttpGet("{customerId:guid}")]
        public async Task<CustomerModel> GetCustomer(Guid customerId)
        {
            return await _customerRepository.Get(customerId);
        }
    }
}
