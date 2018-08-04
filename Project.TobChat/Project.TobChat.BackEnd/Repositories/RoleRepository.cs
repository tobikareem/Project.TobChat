using System.Linq;
using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Repositories
{
    internal class RoleRepository : IRepository<Role>
    {
        public void Add(Role obj)
        {
            using (var context = new TobChatDbContext())
            {
                context.Roles.Add(obj);
                context.SaveChanges();
            }
        }

        public void Update(Role obj)
        {
            using (var context = new TobChatDbContext())
            {
                var update = context.Roles.First(p => p.Id == obj.Id);
                update.RoleName = obj.RoleName;
                update.Department = obj.Department;
                update.Description = obj.Description;

                context.SaveChanges();
            }
        }

        public List<Role> GetAll()
        {
            List<Role> roles;

            using (var context = new TobChatDbContext())
            {
                roles = context.Roles.ToList();
            }

            return roles;
        }

        public void Delete(int id)
        {
            using (var context = new TobChatDbContext())
            {
                var delete = context.Roles.First(p => p.Id == id);
                context.Roles.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
