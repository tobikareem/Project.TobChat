
using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;
using Project.TobChat.BackEnd.Repositories;

namespace Project.TobChat.BackEnd.Services
{
    public class CourseService
    {
        private readonly IRepository<Course> _courseRepository;

        public CourseService()
        {
            _courseRepository = new CourseRepository();
        }

        public void AddCourse(Course obj)
        {
            _courseRepository.Add(obj);
        }

        public void UpdateCourse(Course obj)
        {
            _courseRepository.Update(obj);
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.Delete(id);
        }

        public List<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }
    }
}
