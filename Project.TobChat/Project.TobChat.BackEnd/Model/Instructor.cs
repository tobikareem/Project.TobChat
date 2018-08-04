using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Instructor
    {
        [ForeignKey("Person")]
        public int Id { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public string Speciality { get; set; }


        public virtual Department Department { get; set; }
        public virtual Person Person { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
