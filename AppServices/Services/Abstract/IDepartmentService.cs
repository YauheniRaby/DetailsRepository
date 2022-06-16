using AppServices;
using AppServices.DTOs;
using System.Collections.Generic;

namespace AppServices.Services.Abstract
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentDTO> GetDepartments();

        IEnumerable<string> GetDepartmentNames();

        void AddDepartment(DepartmentDTO department);

        void UpdateDepartment(DepartmentDTO department);

        void DeleteDepartment(int id);
    }
}
