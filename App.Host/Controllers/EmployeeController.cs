using AppServices.DTOs;
using AppServices.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<FullEmployeeDTO>>> GetAsync()
        {
            return await _employeeService.GetAsync();
            
        }

        [HttpGet("details")]
        public async Task<ActionResult<List<EmployeeWithCountDetailsDTO>>> GetWithCountDetailsAsync()
        {
            return await _employeeService.GetEmployeeWithCountDetailsAsync();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveByIdAsync(int id)
        {
            if (await _employeeService.ExistsAsync(id) 
                && await _employeeService.RemoveById(id))
            {
                return Ok();
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync(ShortEmployeeDTO employee)
        {
            await _employeeService.AddAsync(employee);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(FullEmployeeDTO employee)
        {
            if (await _employeeService.ExistsAsync(employee.Id))
            {
                await _employeeService.UpdateAsync(employee);
                return Ok();
            }
            return NotFound();
        }
    }
}
