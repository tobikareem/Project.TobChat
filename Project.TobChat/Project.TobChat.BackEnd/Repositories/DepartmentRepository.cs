
using System;
using System.Collections.Generic;
using System.Linq;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Repositories
{
    internal class DepartmentRepository :IRepository<Department>
    {
        public void Add(Department obj)
        {
            using (var context = new TobChatDbContext())
            {
                context.Departments.Add(obj);
                context.SaveChanges();
            }
        }

        public void Update(Department obj)
        {
            using (var context = new TobChatDbContext())
            {
                var update = context.Departments.First(d => d.Id == obj.Id);
                update.DeptName = obj.DeptName;
                update.InstructorId = obj.InstructorId;

                context.SaveChanges();
            }
        }

        public List<Department> GetAll()
        {
            List<Department> departments;
            using (var context = new TobChatDbContext())
            {
                departments = context.Departments.ToList();
            }

            return departments;
        }

        public void Delete(int id)
        {
            using (var context = new TobChatDbContext())
            {
                var delete = context.Departments.First(d => d.Id == id);
                context.Departments.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
