using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var regtangle = new Regtangle(new System.Drawing.Point(10, 20), 100, 50);

            var shapes = new[] { regtangle };

            foreach (var shape in shapes)
                shape.Draw();

            Console.ReadKey();
        }
    }
}
