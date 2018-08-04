
using System;
using System.Collections.Generic;
using System.Linq;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Repositories
{
    internal class InstructorRepository : IRepository<Instructor>
    {
        public void Add(Instructor obj)
        {
            using (var context = new TobChatDbContext())
            {
                context.Instructors.Add(obj);
                context.SaveChanges();
            }
        }

        public void Update(Instructor obj)
        {
            using (var context = new TobChatDbContext())
            {
                var update = context.Instructors.First(i => i.Id == obj.Id);
                update.Speciality = obj.Speciality;
            }
        }

        public void Delete(int id)
        {
            using (var context = new TobChatDbContext())
            {
                var delete = context.Instructors.First(i => i.Id == id);
                context.Instructors.Remove(delete);
                context.SaveChanges();
            }
        }

        public List<Instructor> GetAll()
        {
            List<Instructor> instructors;
            using (var context = new TobChatDbContext())
            {
                instructors = context.Instructors.ToList();
            }

            return instructors;
        }
    }
}
