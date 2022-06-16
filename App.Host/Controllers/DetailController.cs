using AppData.Model;
using AppServices.DTOs;
using AppServices.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        private readonly IDetailService _detailService;
        private readonly IEmployeeService _employeeService;

        public DetailController(IDetailService detailService, IEmployeeService employeeService)
        {
            _detailService = detailService;
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DetailDTO>>> GetDetailsAsync()
        {
            var result = await _detailService.GetDetailsAsync();
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDetailAsync(int id)
        {
            if(await _detailService.ExistsAsync(id))
            {
                await _detailService.DeleteDetailAsync(id);
                return Ok();
            }
            
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult> AddDetailAsync(CreateDetailDTO detail)
        {
            if(await _employeeService.ExistsAsync(detail.EmployeeId))
            {
                await _detailService.AddDetailAsync(detail);
                return Ok();
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateDetailAsync(UpdateDetailDTO detail)
        {
            if (await _detailService.ExistsAsync(detail.Id)
                && await _employeeService.ExistsAsync(detail.EmployeeId))
            {
                await _detailService.UpdateDetailAsync(detail);
                return Ok();
            }

            return BadRequest();
        }
    }
}
