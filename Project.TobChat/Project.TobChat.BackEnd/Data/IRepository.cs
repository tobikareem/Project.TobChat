using System.Collections.Generic;

namespace Project.TobChat.BackEnd.Data
{
    public interface IRepository <T> where T: class 
    {
        void Add(T obj);
        void Update(T obj);
        List<T> GetAll();
        void Delete(int id);
    }
}