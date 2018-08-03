using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Instructor
    {
        [ForeignKey("Person")]
        public int Id { get; set; }

        public string Speciality { get; set; }

        public ICollection<Department> Departments { get; set; }
        public virtual Person Person { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
