using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace classwork
{
    class Program
    {
        static void Main()
        {
            int n = 2;
            double g = 9.8;

            Console.WriteLine(n);
            Console.WriteLine(g);
            Console.WriteLine(n++ + ++n);
            Console.WriteLine(n);

            int x = 3, y = 4, z = 5;
            Console.WriteLine(x+y*z);

            x = y += 2;
            Console.WriteLine(x);

            double angle = Math.PI/6;
            double sinusX = Math.Sin(angle);
            Console.WriteLine(sinusX);

            //int k;
            //k = 1;

            var k = "1";
            Console.WriteLine(k);

            angle = x;
            Console.WriteLine(angle);

            x = (int)Math.Pow(2, 3);
            Console.WriteLine(x);

            x = (int)Math.Sqrt(3);
            Console.WriteLine(x);

            x = (int)Math.Round(Math.Sqrt(3));
            Console.WriteLine(x);

            Console.WriteLine((int)(-1.5));
            Console.WriteLine(Math.Floor(-1.5));

            Console.ReadKey();

        }


    }
}
