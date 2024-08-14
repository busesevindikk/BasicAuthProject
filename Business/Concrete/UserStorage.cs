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
        // Statik bir liste ile kullanıcıları saklayacağız
        private static readonly List<User> _users = new List<User>();

        // Kullanıcıları eklemek için metod
        public static void AddUser(User user)
        {
            _users.Add(user);
        }

        // Tüm kullanıcıları almak için metod
        public static List<User> GetAllUsers()
        {
            return _users;
        }
    }
}
