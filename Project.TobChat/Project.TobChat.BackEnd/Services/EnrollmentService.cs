using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;
using Project.TobChat.BackEnd.Repositories;

namespace Project.TobChat.BackEnd.Services
{
    public class EnrollmentService
    {
        private readonly IRepository<Enrollment> _enrollRepository;

        public EnrollmentService()
        {
            _enrollRepository = new EnrollmentRepository();
        }

        public void AddCourse(Enrollment obj)
        {
            _enrollRepository.Add(obj);
        }

        public void UpdateCourse(Enrollment obj)
        {
            _enrollRepository.Update(obj);
        }

        public void DeleteCourse(int id)
        {
            _enrollRepository.Delete(id);
        }

        public List<Enrollment> GetAllCourses()
        {
            return _enrollRepository.GetAll();
        }
    }
}
