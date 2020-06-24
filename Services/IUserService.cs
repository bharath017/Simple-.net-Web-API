using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserFinal.Models;

namespace UserFinal.Services
{

    public interface IUserService
    {
        public List<User> GetUsers();

        public User AddUser(User user_details);

        public User UpdateUser(string id, User user_details);

        public string DeleteUser(string id);
        public User GetSingleUser(string id);
    }
}
