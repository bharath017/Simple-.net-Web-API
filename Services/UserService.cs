using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserFinal.Models;

namespace UserFinal.Services
{
    public class UserService : IUserService
    {

        private List<User> user_list;

        public UserService()
        {
            user_list = new List<User>();
        }

        public List<User> GetUsers()
        {
            return user_list;
        }

        public User AddUser(User user_details)
        {
            user_list.Add(user_details);
            return user_details;
        }

        public User UpdateUser(string id, User user_details)
        {
            for (var index = user_list.Count - 1; index >= 0; index--)
            {
                if (user_list[index].ID == id)
                {
                    user_list[index] = user_details;
                }
            }
            return user_details;
        }

        public string DeleteUser(string id)
        {
            for (var index = user_list.Count - 1; index >= 0; index--)
            {
                if (user_list[index].ID == id)
                {
                    user_list.RemoveAt(index);
                }
            }

            return id;
        }

        public User GetSingleUser(string id)
        {
            User User = new User();
            for (var index = user_list.Count - 1; index >= 0; index--)
            {
                if (user_list[index].ID == id)
                {
                    User = user_list[index];
                }
            }
            return User;
        }
    }
}
