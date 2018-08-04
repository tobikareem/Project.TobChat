

using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;
using Project.TobChat.BackEnd.Repositories;

namespace Project.TobChat.BackEnd.Services
{
    public class InstructorService
    {
        private readonly IRepository<Instructor> _instRepository;

        public InstructorService()
        {
            _instRepository = new InstructorRepository();
        }

        public void AddInstructor(Instructor obj)
        {
            _instRepository.Add(obj);
        }

        public void UpdateInstructor(Instructor obj)
        {
            _instRepository.Update(obj);
        }

        public void DeleteInstructor(int id)
        {
            _instRepository.Delete(id);
        }

        public List<Instructor> GetAllInstructor()
        {
            return _instRepository.GetAll();
        }
    }
}
