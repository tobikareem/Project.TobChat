
using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;
using Project.TobChat.BackEnd.Repositories;

namespace Project.TobChat.BackEnd.Services
{
    public class ScheduleService
    {
        private readonly IRepository<Schedule> _scheRepository;

        public ScheduleService()
        {
            _scheRepository = new ScheduleRepository();
        }

        public void AddSchedule(Schedule obj)
        {
            _scheRepository.Add(obj);
        }

        public void UpdateSchedule(Schedule obj)
        {
            _scheRepository.Update(obj);
        }

        public void DeleteSchedule(int id)
        {
            _scheRepository.Delete(id);
        }

        public List<Schedule> GetAllSchedule()
        {
            return _scheRepository.GetAll();
        }
    }
}
