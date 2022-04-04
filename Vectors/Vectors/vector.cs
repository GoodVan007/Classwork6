using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class vector
    {
        public double X;
        public double Y;
        public double Z;

        public vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static vector operator + (vector a, vector b)
        {
            return new vector(
                a.X + b.X,
                a.Y + b.Y,
                a.Z + b.Z);
        }

        public static vector operator -(vector a, vector b)
        {
            return new vector(
                a.X - b.X,
                a.Y - b.Y,
                a.Z - b.Z);
        }

        public static vector operator *(vector a, double k)
        {
            return k * a;
        }

        public static double operator *(vector a, vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static vector operator ^(vector a, vector b)
        {
            return new vector(
                a.Y * b.Z - a.Z*b.Y
                a.Z*b.X - a.X*)
        }

        public override string ToString()
        {
            return $"{X}; {Y}; {Z}";
        }
    }
}
