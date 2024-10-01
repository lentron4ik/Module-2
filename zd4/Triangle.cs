using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4
{
    public class Triangle : IDrawable
    {
        public double Base { get; private set; }
        public double Height { get; private set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем треугольник с основанием: {Base} и высотой: {Height}");
        }
    }
}
