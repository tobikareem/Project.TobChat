using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Student
    {
        [ForeignKey("Person")]
        public int Id { get; set; }
        public string Major { get; set; }
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public int YearLevel { get; set; }

        public virtual Schedule Schedule { get; set; }
        public virtual Person Person { get; set; }
    }
}
