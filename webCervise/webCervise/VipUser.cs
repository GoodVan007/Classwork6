using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webCervise
{
    public class VipUser : RegisteredUser
    {
        private long cardnumber;

        public VipUser(string login, string password, string email, long cardnumder) : base(login, password, email)
        {
            this.cardnumber = cardnumder;            
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Банковская карта {cardnumber}\n");
        }
    }
}
    