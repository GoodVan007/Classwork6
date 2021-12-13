using System;

namespace Classwork12
{
    public class Person
    {
        
        public static string Species = "Homo Sapience";

        public string Name;
        public string Surname;
        public string Age;

        static int number = 1;
        static void Main(string[] args)
        {
            
            Console.WriteLine(Person.Species);

            var peter = new Person();
            peter.Name = "Пётр";
            peter.Surname = "Иванов";
            peter.Age = 17;

            PrintPerson(peter);

            var ann = new Person() { Name = "Анна", Surname = "Сергеевна", Age = 18 };

            Console.ReadKey();
                        
        }
        static void PrintPerson(Person person)
        {
            Console.WriteLine($"{person.Name} {person.Surname}, возраст {person.Age}");

        }
    }
}
