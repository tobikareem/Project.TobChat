

using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;
using Project.TobChat.BackEnd.Repositories;

namespace Project.TobChat.BackEnd.Services
{
    public class PersonService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

        public void AddPeople(Person obj)
        {
            _personRepository.Add(obj);
        }

        public void UpdatePeople(Person obj)
        {
            _personRepository.Update(obj);
        }

        public void DeletePerson(int id)
        {
            _personRepository.Delete(id);
        }

        public List<Person> GetAllPeople()
        {
            return _personRepository.GetAll();
        }
    }
}
