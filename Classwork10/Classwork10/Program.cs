using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork10
{
    class Program
    {
        static void Main(string[] args)
        {
            var poets = new[]
            {
                "Александр Сергеевич Пушкин",
                "Михаил Юрьевич Лермонтов",                
                "Андрей Вознесенский",
                "Борис Владимирович Заходер"
            };

            foreach (var name in poets)
                Console.WriteLine(ShortName(name));

            Console.ReadKey();

        }

        static string ShortName(string fullName)
        {
            
            var names = fullName.Split();
            try
            {
                return $"{names[0][0]}.{names[1][0]}.{names[2]}";
                
            }
            

        }
    }
}
