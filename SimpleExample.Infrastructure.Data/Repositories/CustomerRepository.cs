using Microsoft.EntityFrameworkCore;
using SimpleExample.Core.Data;
using SimpleExample.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleExample.Infrastructure.Data.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly SimpleExampleContext _simpleExampleContext;

        public CustomerRepository(SimpleExampleContext simpleExampleContext)
        {
            _simpleExampleContext = simpleExampleContext;
        }

        public void Add(Customer entity)
        {
            _simpleExampleContext.Customers.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _simpleExampleContext.Customers.Remove(entity);
        }

        public async Task<Customer> Get(Guid id)
        {
            return await _simpleExampleContext.Customers.SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Save()
        {
            return await _simpleExampleContext.SaveChangesAsync() > 0;
        }
    }
}
