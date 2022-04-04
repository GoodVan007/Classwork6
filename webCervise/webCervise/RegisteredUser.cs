﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webCervise
{
    public class RegisteredUser : User
    {
        public string Email;
        protected string password;

        public RegisteredUser(string login, string password, string email) : base(login)
        {
            Email = email;
            this.password = password;
        }

        public override void PrintInfo()
        {
            //base.PrintInfo();
            Console.WriteLine($"Пользователь {Login}, E-mail {Email}");
        }
    }
}
