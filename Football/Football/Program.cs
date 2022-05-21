using System;
using System.Collections.Generic;
using System.IO;


namespace Football
{
    class Program
    {
        static void Main()
        {
            var champions = new Dictionary<string, int>();
            // тут надо открыть в решении файл с текстом, которым мы будем пользоваться(у меня его нет)

            using (var file = new StreamReader("football.txt", Encoding.Default)) //из-за того, что у меня нет Файла с футбольными командами - висит ошибка
                while (!file.EndOfStream)
                {
                    var key = file.ReadLine().Split('\t')[1]; // прочитали строчку, разбили по табуляции, разделили по индексу 1
                    if (champions.ContainsKey(key))
                        champions[key]++;
                    else
                        champions[key] = 1;
                }
            foreach (var team in champions.Keys)
                Console.WriteLine($"{team} - {champions[team]}");

            Console.ReadKey();
        }
        
    }
}
