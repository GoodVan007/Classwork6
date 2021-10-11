using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X:");
            var x = bool.Parse(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            var y = bool.Parse(Console.ReadLine());

            Console.WriteLine($"!x = {!x}, !y = {!y}");
            Console.WriteLine($"x & y = {x & y}, x | y, x^y = {x ^ y}");

            Console.ReadKey();
        }
    }
}
