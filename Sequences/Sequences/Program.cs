using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Numerics;

namespace Sequences
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sequence = new Sequences();

            Console.WriteLine("Последовательность Фибоначчи");

            PringSequense(sequence.Fibonacci());

            Console.WriteLine("\nФакториалы");
            PringSequense(sequence.Factorial());

            Console.ReadKey();
        }


        static void PringSequense(IEnumerable<BigInteger> s)
        {

            var i = 0;
            foreach(var elem in s)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{i++}: {elem}");

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Enter)
                        break;
                }
            }
        }
    }
}
