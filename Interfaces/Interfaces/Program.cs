using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            var car = new Cars();
            var plane = new Plane();

            IDivable[] vehicles = new IDivable[] { car, plane };
        }
    }
}
