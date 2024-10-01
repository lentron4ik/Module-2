using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    internal class zd2
    {
        static void Main(string[] args)
        {
            // Ввод радиуса круга
            Console.Write("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());
            Shape circle = new Circle(radius); // Создание объекта Circle

            Console.WriteLine("Круг:");
            Console.WriteLine("Площадь: " + circle.Area());
            Console.WriteLine("Периметр: " + circle.Perimeter());

            Console.Write("\nВведите ширину прямоугольника: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Введите высоту прямоугольника: ");
            double height = double.Parse(Console.ReadLine());

            Shape rectangle = new Rectangle(width, height); // Создание объекта Rectangle

            Console.WriteLine("Прямоугольник:");
            Console.WriteLine("Площадь: " + rectangle.Area());
            Console.WriteLine("Периметр: " + rectangle.Perimeter());

            Console.ReadLine();
        }
    }
}