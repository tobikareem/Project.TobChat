using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public string Assignment { get; set; }
        public double Credit { get; set; }

        public virtual Schedule Schedule { get; set; }
        public virtual Department Department { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}
