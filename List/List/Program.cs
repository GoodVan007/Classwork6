using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 5, 0 };
            var lines = new List<string>();
            numbers[1] = 7;
            var n = numbers[0] + numbers[1];
            Console.WriteLine($"n = {n}");

            // count - число элементов в списке
            // Capacity - число зарезервированных элементов для хранения списка в памяти

            // add(elem) - добавить элемент в конец списка

            lines.Add("Первая строка");
            lines.Add("Вторая строка");

            Console.WriteLine($"numbers Capacity = {numbers.Capacity}"); 
            numbers.Add(9);            

            Console.WriteLine($"numbers capacity = {numbers.Capacity}");

            //Insert(i, elem) - вставка elem по индексу i
            numbers.Insert(2, 4);
            // Еслит делать "numbers[2] = 4", то мы просто заменим символ под номером "2", а если мы делаем через "Insert", то мы "вставляем" элемент

            numbers.Add(4);

            Console.WriteLine($"Первое вхождение \"4\" по индексу {numbers.IndexOf(4)}");
            Console.WriteLine($"последнее вхождение \"4\" по индексу {numbers.LastIndexOf(4)}");
            Console.WriteLine($"Первое вхождение \"11\" по индексу {numbers.IndexOf(11)}");
            Console.WriteLine($"Последнее вхождение \"11\" по индексу {numbers.LastIndexOf(11)}");
            //numbers.Remove(4);        Remove - убираем первое совпадение
            // RemoveAt(i) - Удаляем по конкретному индексу
            numbers.RemoveAt(6);
            numbers.Remove(4);            

            //Contains(elem) - можно выяснить есть ли "такой" элемент в списке            

            var answer = numbers.Contains(1) ? "Да" : "нет";
            Console.WriteLine($"Есть ли в списке 1? {answer}");
            answer = numbers.Contains(11) ? "Да" : "нет";
            Console.WriteLine($"Есть ли в списке 11? {answer}");


            numbers.Clear();
            //Clear() - очистка списка

            Console.ReadKey();
        }
    }
}
