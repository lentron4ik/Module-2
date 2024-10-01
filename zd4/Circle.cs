using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4
{
    public class Circle : IDrawable 
    {
        public double Radius { get; private set; }

        public Circle(double radius) // Конструктор
        {
            Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем круг с радиусом: {Radius}");
        }
    }
}
