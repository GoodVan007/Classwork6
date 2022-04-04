using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Triangle
    {
        public Point A;
        public Point B;
        public Point C;

        public Segment AB
        {
            get
            {
                return new Segment(A, B);
            }
        }

        public Segment AC
        {
            get
            {
                return new Segment(A, C);
            }
        }

        Public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void Rotate(Point center, double angleInDegrees)
        {
            A.Rotate(center, angleInDegrees);
            B.Rotate(center, angleInDegrees);
            C.Rotate(center, angleInDegrees);
        }
    }
}
