using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Student Student { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
