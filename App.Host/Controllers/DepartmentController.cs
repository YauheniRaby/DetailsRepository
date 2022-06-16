using AppServices.DTOs;
using AppServices.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace App.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentServise;

        public DepartmentController(IDepartmentService departmentServise)
        {
            _departmentServise = departmentServise;
        }
       
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_departmentServise.GetDepartments());
        }

        [HttpPost]
        public JsonResult Post(DepartmentDTO dep)
        {
            _departmentServise.AddDepartment(dep);
            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(DepartmentDTO dep)
        {
            _departmentServise.UpdateDepartment(dep);
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}") ]
        public JsonResult Delete(int id)
        {
            _departmentServise.DeleteDepartment(id);
            return new JsonResult("Deleted Successfully");
        }

        [Route("GetAllDepartmentNames")]
        [HttpGet]
        public JsonResult GetAllDepartmentNames()
        {
            return new JsonResult(_departmentServise.GetDepartmentNames());
        }
    }
}
