using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndDirectorits
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!File.Exists("text.txt"))
                File.Create("text.txt").Close();
            
            File.Copy("text.txt", "copy.txt", true);
            //File.Delete("text.txt");

            var file = new FileInfo("copy.txt");
            Console.WriteLine(file.FullName);

            File.WriteAllText("text.txt", "Hello, World!");
            File.AppendAllText("text.txt", "\nПривет, мир!");

            var lines = new[] { "","Посмотри! Блять, просто посмотри!", "Как прекрасен этот мир!" };
            File.AppendAllLines("text.txt", lines);

            var text = File.ReadAllText("text.txt");
            Console.WriteLine(text);

            //Console.Write("=====Конец первой печати===== ");

            var textLines = File.ReadAllLines("text.txt");
            PrintLines(textLines);

            Console.WriteLine();

            using(var stream = new StreamWriter("stream.txt", true))
            {
                Console.WriteLine("Введите текст построчно. Enter  в начале строки - конеч ввода.");

                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == string.Empty)
                        break;

                    stream.WriteLine(input);
                }
            }
            Console.WriteLine();

            using (var stream = new StreamReader("stream.txt"))
            {
                Console.WriteLine("========");
                while (!stream.EndOfStream)
                {
                    Console.WriteLine(stream.ReadLine());
                }
                Console.WriteLine("=========");
            }

            var dirName = Directory.GetCurrentDirectory();
            var listOfFiles = Directory.GetFiles(dirName);
            PrintLines(listOfFiles);

            Console.WriteLine();

            var currentDirectory = new DirectoryInfo(".");
            Console.WriteLine(currentDirectory.Name);

            var files = currentDirectory.GetFiles();
            PrintFilesNames(files);

            var dirs = currentDirectory.GetDirectories();
            PrintDirectoryNames(dirs);

            Console.ReadKey();
        }

        static void PrintLines(string[] lines)
        {
            foreach (var line in lines)
                Console.WriteLine(line);
        }

        static void PrintFilesNames(FileInfo[] files)
        {
            foreach (var file in files)
                Console.WriteLine(file.Name);
        }

        static void PrintDirectoryNames(DirectoryInfo[] directiries)
        {
            foreach (var directory in directiries)
                Console.WriteLine(directory.Name);
        }
    }
}
