using Microsoft.EntityFrameworkCore;
using SimpleExample.Domain;

namespace SimpleExample.Infrastructure.Data
{
    public class SimpleExampleContext : DbContext
    {
        public DbSet<Customer> Customers { get; private set; }
        public SimpleExampleContext(DbContextOptions<SimpleExampleContext> options) : base(options) { }
    }
}
