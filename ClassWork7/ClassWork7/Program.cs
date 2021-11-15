using System;


namespace ClassWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("НАХУУУУЙ УрФУ с его дистантом и переобуванием(как у моих родителей)");
            Console.ReadKey();
            Console.WriteLine("Нахуй лок даун, сука гет даун. Ствол у виска клик-клэк, пиу-пау");
            Console.WriteLine("Мама don`t Cry кого-то въебал, пару пинт лина и лаве на paypal");
            Console.WriteLine("© Баранский В.А.");
            Console.ReadKey();

            Console.WriteLine("Введите начальное значение аргумента");
            var x0 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение шага");
            var step = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число строк таблицы");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(" x | x^2");
            Console.WriteLine(new string('-', 15));

            PrintHeader("x^2");

            for(var i = 0; i < n; i++)
            {
                
                Console.WriteLine($"{x0,5:F2} | {x0 * x0:F3}");
                x0 += step;
            }
                        
            PrintHeader("sin x");

            for (var i = 0; i < n; i++)
            {
                var arg = x0 + step * i;
                Console.WriteLine($"{arg + step * 1,5:F2} | {Math.Sin(arg)}");
            }
            
            Console.ReadKey();
        }
        static void PrintHeader(string functionName)
        {
            Console.WriteLine(" x | x^2");
            Console.WriteLine(new string('-', 15));
        }
 

    }
}
