using System;

namespace Classwork8
{
    class Program
    {
        static void Main(string[] args)
        {   
            const ulong UpperBound = ulong.MaxValue;
            var p = (ulong)2;
            var power = (ulong)2;
            while (power < UpperBound)
            {
                power *= 2;
                var Mp = power - 1;
                if (IsPrime(p) && IsPrime(Mp))
                    Console.WriteLine($"p = {p} Mp={Mp}");
                p++;
            }
            Console.ReadKey();
        }

        static bool IsPrime(ulong number)
        {
            var d = (ulong)2;
            while(d < Math.Sqrt(number))
            {
                if (number % d == 0)
                    return false;
                d++;
            }
            return true;
        }
    }
}
