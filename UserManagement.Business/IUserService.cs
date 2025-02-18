using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Data.Models;

namespace UserManagement.Business
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
