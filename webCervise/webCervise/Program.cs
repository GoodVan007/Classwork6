using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace webCervise
{
    class Program
    {
        static void Main(string[] args)
        {
            var george = new User();
            george.Login = "George032";

            var Kate = new User("Kate89");

            var john = new RegisteredUser("John","qwerty", "john@yandex.ru");

            var paul = new VipUser("Paul123", "456789", "paul@gmail.com", 2400455577777807);

            var admin = new Admin("Sergey", "admin1234", "sergey.admin@mail.ru", 2);

            var users = new[] { george, Kate, john, paul, admin };

            object  obj = new object();

            RegisteredUser reguser = paul as RegisteredUser;

            VipUser vip = Kate as VipUser;

            foreach (var user in users)
                user.PrintInfo();

            Console.ReadKey();
        }
    }
}
