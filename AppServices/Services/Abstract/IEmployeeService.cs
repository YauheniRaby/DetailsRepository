using AppServices.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppServices.Services.Abstract
{
    public interface IEmployeeService
    {
        Task<bool> ExistsAsync(int id);

        Task<List<FullEmployeeDTO>> GetEmployeeAsync();

        Task<List<EmployeeWithCountDetailsDTO>> GetEmployeeWithCountDetailsAsync();

        Task<bool> RemoveById(int id);

        Task AddAsync(ShortEmployeeDTO employee);

        Task UpdateAsync(FullEmployeeDTO employee);
    }
}
