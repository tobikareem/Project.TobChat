
using System;
using System.Collections.Generic;
using System.Linq;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Repositories
{
    internal class StudentRepository : IRepository<Student>
    {
        public void Add(Student obj)
        {
            using (var context = new TobChatDbContext())
            {
                context.Students.Add(obj);
                context.SaveChanges();

            }
        }

        public void Update(Student obj)
        {
            using (var context = new TobChatDbContext())
            {
                var update = context.Students.First(s => s.Id == obj.Id);
                update.Major = obj.Major;
                update.ScheduleId = obj.ScheduleId;
                update.YearLevel = obj.YearLevel;

                context.SaveChanges();
            }
        }

        public List<Student> GetAll()
        {
            List<Student> students;
            using (var context = new TobChatDbContext())
            {
                students = context.Students.ToList();
            }

            return students;
        }

        public void Delete(int id)
        {
            using (var context = new TobChatDbContext())
            {
                var delete = context.Students.First(s => s.Id == id);
                context.Students.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
