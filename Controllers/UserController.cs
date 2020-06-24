using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserFinal.Models;
using UserFinal.Services;

namespace UserFinal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private IUserService _service;


        public UserController(IUserService service)
        {

            _service = service;

        }

        [HttpGet("getUsers")]
        public ActionResult<List<User>> GetUsers()
        {
            return _service.GetUsers();
        }

        [HttpPost("addUser")]
        public ActionResult<User> AddUser(User User)
        {
            _service.AddUser(User);
            return User;
        }

        [HttpPut("updateUser/{id}")]
        public ActionResult<User> UpdateUser(string id, User User)
        {
            _service.UpdateUser(id, User);
            return User;
        }

        [HttpDelete("deleteUser/{id}")]
        public ActionResult<string> DeleteUser(string id)
        {
            _service.DeleteUser(id);

            return id;
        }


        [HttpGet("getSingleUser/{id}")]
        public ActionResult<User> GetSingleUser(string id)
        {
            return _service.GetSingleUser(id);
        }
    }
}
