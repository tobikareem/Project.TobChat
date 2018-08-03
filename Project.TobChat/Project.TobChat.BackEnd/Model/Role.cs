using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.TobChat.BackEnd.Model
{
    public class Role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string RoleName { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
