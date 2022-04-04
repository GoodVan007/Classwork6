using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webCervise
{
    class Admin : RegisteredUser
    {
        public int acsessLevel;

        public Admin(string login, string password, string email, int level) : base(login, password, email)
        {
            acsessLevel = level;
        }

        public override void PrintInfo()
        {
            Console.Write($"Администратор {Login}\n");

            if (acsessLevel < 3)
                Console.WriteLine($"Email: {Email}");
        }
    }
}
