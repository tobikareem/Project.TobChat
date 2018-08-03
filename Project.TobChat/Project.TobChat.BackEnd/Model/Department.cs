using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string DeptName { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }

        public ICollection<Course> Courses { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
