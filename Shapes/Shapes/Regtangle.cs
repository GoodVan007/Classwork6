using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public class Regtangle : Shape
    {
        public Point TopLeft;

        private float width;

        public float Width
        {
            get { return Width; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательная величина");
                Width = value;
            }
        }

        private float height;

        public float Height
        {
            get { return height; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательная величина");
                height = value;
            }
        }

        public Regtangle(Point p, float w, float h) : this(p,w,h, Color.Black);
        
        public override void Draw()
        {
            Console.Write("Рисуем ");
            PrintInfo();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Прямоугольник с вершиной({TopLeft.X};{TopLeft.Y}) шириной {Width} и высотой {Height}");
        }
    }
}
