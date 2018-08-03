using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Enrollment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public char Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}
