using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Data.Models;
using UserManagement.Data;

namespace UserManagement.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers() => _userRepository.GetUsers();

        public User GetUser(int id) => _userRepository.GetUserById(id);

        public void CreateUser(User user) => _userRepository.AddUser(user);

        public void UpdateUser(User user) => _userRepository.UpdateUser(user);

        public void DeleteUser(int id) => _userRepository.DeleteUser(id);
    }
}
