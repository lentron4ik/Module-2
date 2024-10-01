using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    public class Rectangle : Shape // наследование от класса shape
    {
        private double length;
        private double width;

        // Конструктор для инициализации длины и ширины
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        /*override используется для того, чтобы в дочернем классе переопределить метод,
        который был объявлен как abstract или virtual в базовом классе.
        Поэтому здесь мы как бы явно указываем что данные методы переопределяют*/
        // Переопределение метода Area()
        public override double Area()
        {
            return length * width;
        }

        // Переопределение метода Perimeter()
        public override double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}