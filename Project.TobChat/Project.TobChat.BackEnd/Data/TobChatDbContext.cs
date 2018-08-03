using System.Data.Entity;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Data
{
    class TobChatDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
