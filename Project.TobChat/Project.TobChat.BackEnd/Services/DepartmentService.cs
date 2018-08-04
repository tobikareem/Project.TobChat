

using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;
using Project.TobChat.BackEnd.Repositories;

namespace Project.TobChat.BackEnd.Services
{
    public class DepartmentService
    {
        private readonly IRepository<Department> _deptRepository;

        public DepartmentService()
        {
            _deptRepository = new DepartmentRepository();
        }

        public void AddDepartment(Department obj)
        {
            _deptRepository.Add(obj);
        }

        public void UpdateDepartment(Department obj)
        {
            _deptRepository.Update(obj);
        }

        public void DeleteDepartment(int id)
        {
            _deptRepository.Delete(id);
        }

        public List<Department> GetAllDepartments()
        {
            return _deptRepository.GetAll();
        }
    }
}
