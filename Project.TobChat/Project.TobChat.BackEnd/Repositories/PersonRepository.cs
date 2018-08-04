

using System;
using System.Collections.Generic;
using System.Linq;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Repositories
{
    internal class PersonRepository : IRepository<Person>
    {
        public void Add(Person obj)
        {
            using (var context = new TobChatDbContext())
            {
                context.People.Add(obj);
                context.SaveChanges();
            }
        }

        public void Update(Person obj)
        {
            using (var context = new TobChatDbContext())
            {
                var update = context.People.First(p => p.Id == obj.Id);
                update.FirstName = obj.FirstName;
                update.LastName = obj.LastName;
                update.MiddleName = obj.MiddleName;
                update.Password = obj.Password;
                update.Email = obj.Email;

                context.SaveChanges();
            }
        }

        public List<Person> GetAll()
        {
            List<Person> people;

            using (var context = new TobChatDbContext())
            {
                people = context.People.ToList();
            }

            return people;
        }

        public void Delete(int id)
        {
            using (var context = new TobChatDbContext())
            {
                var delete = context.People.First(p => p.Id == id);
                context.People.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
