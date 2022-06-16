using AppData.Configuration;
using AppData.Model;
using AppData.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly RepositoryContext _context;

        public EmployeeRepository(RepositoryContext context)
        {
            _context = context;
        }

        public Task<bool> ExistsAsync(int id)
        {
            return _context.Employees.AnyAsync(x => x.Id == id && !x.IsRemove);
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            return _context.Employees.Where(x => !x.IsRemove).ToListAsync();
        }

        public Task<List<EmployeeWithCountDetails>> GetEmployeesWithCountDetailsAsync()
        {
            return _context.Employees.Where(x => !x.IsRemove).Select(x=> new EmployeeWithCountDetails
                {
                    Id = x.Id,
                    Name = x.Name,
                    CountDetails = x.Details.Count()
                }) 
                .ToListAsync();
        }

        public Task RemoveEmployeeByIdAsync(int id)
        {
            var employee = _context.Employees.Find(id);
            employee.IsRemove = true;
            return _context.SaveChangesAsync();
        }

        public Task<int> GetCountDetailsByIdAsync(int id)
        {
            return _context.Employees.Where(x => x.Id == id).Select(x => x.Details.Count()).FirstOrDefaultAsync();            
        }

        public Task AddAsync(Employee employee) 
        {
            _context.Employees.Add(employee);
            return _context.SaveChangesAsync();
        }

        public Task UpdateAsync(Employee employee)
        {
            var currentEmployee = _context.Employees.Find(employee.Id);
            _context.Entry(currentEmployee).CurrentValues.SetValues(employee);

            return _context.SaveChangesAsync();
        }
    }
}
