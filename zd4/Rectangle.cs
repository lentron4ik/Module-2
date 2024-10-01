using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4
{
    public class Rectangle : IDrawable
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height) // Конструктор
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем прямоугольник с шириной: {Width} и высотой: {Height}");
        }
    }
}
