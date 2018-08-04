
using System.Collections.Generic;
using System.Linq;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Repositories
{
    internal class CourseRepository :IRepository<Course>
    {
        public void Add(Course obj)
        {
            using (var context = new TobChatDbContext())
            {
                context.Courses.Add(obj);
                context.SaveChanges();
            }
        }

        public void Update(Course obj)
        {
            using (var context = new TobChatDbContext())
            {
                var update = context.Courses.First(c => c.Id == obj.Id);
                update.CourseTitle = obj.CourseTitle;
                update.DepartmentId = obj.DepartmentId;
                update.ScheduleId = obj.ScheduleId;
                update.Assignment = obj.Assignment;
                update.Credit = obj.Credit;

                context.SaveChanges();
            }
        }

        public List<Course> GetAll()
        {
            List<Course> courses;
            using (var context = new TobChatDbContext())
            {
                courses = context.Courses.ToList();
            }

            return courses;
        }

        public void Delete(int id)
        {
            using (var context = new TobChatDbContext())
            {
                var delete = context.Courses.First(c => c.Id == id);
                context.Courses.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
