using AppData.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppData.Repositories.Abstract
{
    public interface IEmployeeRepository
    {
        Task<bool> ExistsAsync(int id);

        Task<List<Employee>> GetAsync();

        Task<List<EmployeeWithCountDetails>> GetEmployeesWithCountDetailsAsync();

        Task RemoveByIdAsync(int id);

        Task<int> GetCountDetailsByIdAsync(int id);

        Task AddAsync(Employee employee);

        Task UpdateAsync(Employee employee);
    }
}
