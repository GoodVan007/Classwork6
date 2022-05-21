using System;

namespace Delegates
{
    delegate double Function(double x);

    class Program
    {
        static void Main()
        {
            Function f;

            f = Math.Sin;
            Console.WriteLine($"sin(п/4) = {f(Math.PI / 4)}");

            f = Square;
            Console.WriteLine($"(п/4)^2 = {f(Math.PI / 4)}");

            var calc = new Calculator();
            f = calc.Cube;
            Console.WriteLine($"(п/4)^3 = {f(Math.PI / 4)}");

            Console.ReadKey();
        }
        static double Square(double x)
        {
            return x * x;
        }

        static int Floor(double x)
        {

        }
    }
}
