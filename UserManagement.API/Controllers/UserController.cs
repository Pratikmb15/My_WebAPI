using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserManagement.Business;
using UserManagement.Data.Models;

namespace UserManagement.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getusers")]
        public ActionResult<IEnumerable<User>> GetUsers() => Ok(_userService.GetAllUsers());

        [Route("getUserbyId")]
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id) => Ok(_userService.GetUser(id));

        [HttpPost]
        public ActionResult CreateUser([FromBody] User user)
        {
            _userService.CreateUser(user);
            return Ok("User added successfully.");
        }

        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, [FromBody] User user)
        {
            user.Id = id;
            _userService.UpdateUser(user);
            return Ok("User updated successfully.");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return Ok("User deleted successfully.");
        }
    }
}
