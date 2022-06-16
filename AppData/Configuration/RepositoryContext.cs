using AppData.Model;
using Microsoft.EntityFrameworkCore;

namespace AppData.Configuration
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Detail> Details { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
