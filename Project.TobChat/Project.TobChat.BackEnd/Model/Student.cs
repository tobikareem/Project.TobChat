using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Student
    {
        [ForeignKey("Person")]
        public int Id { get; set; }
        [ForeignKey("Department")]
        public int Major { get; set; }
        
        public int YearLevel { get; set; }
        
        public virtual Person Person { get; set; }
        public virtual Department Department { get; set; }
    }
}
