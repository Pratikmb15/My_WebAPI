using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Data.Models;

namespace UserManagement.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        void Save();
    }
}
