using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webCervise
{
    public class Service
    {
        private List<User> users = new List<User>();

        public void Login(User user)
        {
            if (!users.Contains(user))
            {
                users.Add(user);
                Console.WriteLine($"> {user.Login} присоединился");
            }
        }

    }
}
