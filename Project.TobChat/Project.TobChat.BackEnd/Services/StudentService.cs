
using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;
using Project.TobChat.BackEnd.Repositories;

namespace Project.TobChat.BackEnd.Services
{
    public class StudentService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();   
        }

        public void AddStudent(Student obj)
        {
            _studentRepository.Add(obj);
        }

        public void UpdateStudent(Student obj)
        {
            _studentRepository.Update(obj);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.Delete(id);
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }
    }
}
