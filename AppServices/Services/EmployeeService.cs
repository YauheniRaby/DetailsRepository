using AppData.Model;
using AppData.Repositories.Abstract;
using AppServices.DTOs;
using AppServices.Services.Abstract;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppServices.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public Task<bool> ExistsAsync(int id)
        {
            return _employeeRepository.ExistsAsync(id);
        }

        public async Task<List<FullEmployeeDTO>> GetEmployeeAsync()
        {
            var employee = await _employeeRepository.GetEmployeesAsync();
            return _mapper.Map<List<FullEmployeeDTO>>(employee);
        }

        public async Task<List<EmployeeWithCountDetailsDTO>> GetEmployeeWithCountDetailsAsync()
        {
            var employee = await _employeeRepository.GetEmployeesWithCountDetailsAsync();
            return _mapper.Map<List<EmployeeWithCountDetailsDTO>>(employee);
        }

        public async Task<bool> RemoveById(int id)
        {
            var countDetails = await _employeeRepository.GetCountDetailsByIdAsync(id);
            if(countDetails == 0)
            {
                await _employeeRepository.RemoveEmployeeByIdAsync(id);
                return true;
            }
            return false;            
        }

        public Task AddAsync(ShortEmployeeDTO employee)
        {
            var employeeModel = _mapper.Map<Employee>(employee);
            return _employeeRepository.AddAsync(employeeModel);
        }

        public Task UpdateAsync(FullEmployeeDTO employee)
        {
            var employeeModel = _mapper.Map<Employee>(employee);
            return _employeeRepository.UpdateAsync(employeeModel);
        }        
    }
}
