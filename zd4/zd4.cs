using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd4
{
    internal class zd4
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество фигур для рисования: ");
            int count = int.Parse(Console.ReadLine());

            // Создание массива объектов, реализующих интерфейс IDrawable
            IDrawable[] shapes = new IDrawable[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Выберите фигуру для {i + 1}-й: \n1) Круг \n2) Прямоугольник \n3) Треугольник");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Круг
                        Console.Write("Введите радиус круга: ");
                        double radius = double.Parse(Console.ReadLine());
                        shapes[i] = new Circle(radius);
                        break;

                    case 2: // Прямоугольник
                        Console.Write("Введите ширину прямоугольника: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.Write("Введите высоту прямоугольника: ");
                        double height = double.Parse(Console.ReadLine());
                        shapes[i] = new Rectangle(width, height);
                        break;

                    case 3: // Треугольник
                        Console.Write("Введите основание треугольника: ");
                        double baseLength = double.Parse(Console.ReadLine());
                        Console.Write("Введите высоту треугольника: ");
                        double triangleHeight = double.Parse(Console.ReadLine());
                        shapes[i] = new Triangle(baseLength, triangleHeight);
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }

            // Вызов метода Draw() для каждого объекта
            Console.WriteLine("\nРисуем фигуры:");
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
    }
}