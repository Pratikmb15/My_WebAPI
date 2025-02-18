using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Data.Context;
using UserManagement.Data.Models;
using System.Linq;

namespace UserManagement.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers() => _context.Users.ToList();

        public User GetUserById(int id) => _context.Users.Find(id);

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            Save();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            Save();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                Save();
            }
        }

        public void Save() => _context.SaveChanges();
    }
}
