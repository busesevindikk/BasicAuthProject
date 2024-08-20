using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserContract;

namespace Business.Concrete
{
    public class UserStorage
    {
        private static readonly List<User> _users = new List<User>();

        public static void AddUser(User user)
        {
            _users.Add(user);
        }

     
        public static List<User> GetAllUsers()
        {
            return _users;
        }
    }
}
