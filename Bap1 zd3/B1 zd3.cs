using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bap1_zd3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных для Круга
            Console.WriteLine("Введите радиус круга:");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine($"Круг: Площадь = {circle.Area():F2}, Периметр = {circle.Perimeter():F2}");

            // Ввод данных для Прямоугольника
            Console.WriteLine("\nВведите ширину прямоугольника:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту прямоугольника:");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine($"Прямоугольник: Площадь = {rectangle.Area():F2}, Периметр = {rectangle.Perimeter():F2}");

            // Ввод данных для Треугольника
            Console.WriteLine("\nВведите длину первой стороны треугольника:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны треугольника:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину третьей стороны треугольника:");
            double c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);
            Console.WriteLine($"Треугольник: Площадь = {triangle.Area():F2}, Периметр = {triangle.Perimeter():F2}");

            Console.ReadLine();
        }
    }
}