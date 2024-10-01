using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    public class Circle : Shape
    {
        private double radius;

        // Конструктор для инициализации радиуса
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Переопределение метода Area()
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        // Переопределение метода Perimeter()
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}