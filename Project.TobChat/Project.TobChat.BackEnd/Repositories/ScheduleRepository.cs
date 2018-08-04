using System.Collections.Generic;
using System.Linq;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;

namespace Project.TobChat.BackEnd.Repositories
{
    class ScheduleRepository :IRepository<Schedule>
    {
        public void Add(Schedule obj)
        {
            using (var context = new TobChatDbContext())
            {
                context.Schedules.Add(obj);
                context.SaveChanges();
            }
        }

        public void Update(Schedule obj)
        {
            using (var context = new TobChatDbContext())
            {
                var update = context.Schedules.First(p => p.Id == obj.Id);
                update.Location = obj.Location;
                update.ClassTime = obj.ClassTime;
                context.SaveChanges();
            }
        }

        public List<Schedule> GetAll()
        {
            List<Schedule> schedules;

            using (var context = new TobChatDbContext())
            {
                schedules = context.Schedules.ToList();
            }

            return schedules;
        }

        public void Delete(int id)
        {
            using (var context = new TobChatDbContext())
            {
                var delete = context.Schedules.First(p => p.Id == id);
                context.Schedules.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
