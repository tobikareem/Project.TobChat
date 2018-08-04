

using System.Collections.Generic;
using System.Linq;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Repositories
{
    internal class EnrollmentRepository : IRepository<Enrollment>
    {
        public void Add(Enrollment obj)
        {
            using (var context = new TobChatDbContext())
            {
                context.Enrollments.Add(obj);
                context.SaveChanges();

            }
        }

        public void Update(Enrollment obj)
        {
            using (var context = new TobChatDbContext())
            {
                var update = context.Enrollments.First(s => s.Id == obj.Id);
                update.CourseId = obj.CourseId;
                update.StudentId = obj.StudentId;
                update.Grade = obj.Grade;

                context.SaveChanges();
            }
        }

        public List<Enrollment> GetAll()
        {
            List<Enrollment> enrollments;
            using (var context = new TobChatDbContext())
            {
                enrollments = context.Enrollments.ToList();
            }

            return enrollments;
        }

        public void Delete(int id)
        {
            using (var context = new TobChatDbContext())
            {
                var delete = context.Enrollments.First(s => s.Id == id);
                context.Enrollments.Remove(delete);
                context.SaveChanges();
            }
        }

        
    }
}
