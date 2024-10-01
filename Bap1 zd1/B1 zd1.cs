using System;

namespace Bap1_zd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя данные для нескольких студентов
            Console.Write("Введите количество студентов: ");
            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"\nВведите данные для студента {i + 1}:");

                // Ввод имени
                Console.Write("Имя: ");
                string firstName = Console.ReadLine();

                // Ввод фамилии
                Console.Write("Фамилия: ");
                string lastName = Console.ReadLine();

                // Ввод возраста
                Console.Write("Возраст: ");
                int age = int.Parse(Console.ReadLine());

                // Ввод среднего балла
                Console.Write("Средний балл: ");
                double average = double.Parse(Console.ReadLine());

                // Создаем экземпляр класса "Студент"
                Student student = new Student(firstName, lastName, age, average);

                // Выводим информацию о студенте
                student.DisplayInfo();
            }

            Console.ReadLine(); // Ожидание, чтобы консоль не закрывалась сразу
        }
    }
}
