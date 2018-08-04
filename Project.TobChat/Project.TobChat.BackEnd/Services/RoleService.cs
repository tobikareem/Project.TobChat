
using System.Collections.Generic;
using Project.TobChat.BackEnd.Data;
using Project.TobChat.BackEnd.Model;
using Project.TobChat.BackEnd.Repositories;

namespace Project.TobChat.BackEnd.Services
{
    public class RoleService
    {
        private readonly IRepository<Role> _roleRepository;

        public RoleService()
        {
            _roleRepository = new RoleRepository();
        }

        public void AddRole(Role obj)
        {
            _roleRepository.Add(obj);
        }

        public void UpdateRole(Role obj)
        {
            _roleRepository.Update(obj);
        }

        public void DeleteRole(int id)
        {
            _roleRepository.Delete(id);
        }

        public List<Role> GetAllRoles()
        {
            return _roleRepository.GetAll();
        }
    }
}
