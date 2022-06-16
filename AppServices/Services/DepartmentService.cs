using AppServices.DTOs;
using AppServices.Services.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace AppServices.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly List<DepartmentDTO> _departments = new List<DepartmentDTO>()
        {
            new DepartmentDTO(){ DepartmentId = 1,  DepartmentName = "Test1"},
            new DepartmentDTO(){ DepartmentId = 2,  DepartmentName = "Test2"},
        };

        public void AddDepartment(DepartmentDTO department)
        {
            int id = _departments.Select(x => x.DepartmentId).Max();
            department.DepartmentId = ++id;
            _departments.Add(department);
        }

        public void DeleteDepartment(int id)
        {
            _departments.RemoveAll(x => x.DepartmentId == id);
        }

        public IEnumerable<string> GetDepartmentNames()
        {
            return _departments.Select(x => x.DepartmentName);
        }

        public IEnumerable<DepartmentDTO> GetDepartments()
        {
            return _departments;
        }

        public void UpdateDepartment(DepartmentDTO department)
        {
            int index = _departments.IndexOf(_departments.Where(n => n.DepartmentId == department.DepartmentId).FirstOrDefault());
            _departments[index] = department;
        }
    }
}
