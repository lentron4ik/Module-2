using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1
{
    internal class zd1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные для первого человека:");
            Console.Write("Имя: ");
            string name1 = Console.ReadLine();

            Console.Write("Возраст: ");
            int age1 = int.Parse(Console.ReadLine());

            Console.Write("Адрес: ");
            string address1 = Console.ReadLine();

            // Создание первого объекта Person
            Person person1 = new Person(name1, age1, address1);

            Console.WriteLine("\nВведите данные для второго человека:");
            Console.Write("Имя: ");
            string name2 = Console.ReadLine();

            Console.Write("Возраст: ");
            int age2 = int.Parse(Console.ReadLine());

            Console.Write("Адрес: ");
            string address2 = Console.ReadLine();

            // Создание второго объекта Person
            Person person2 = new Person(name2, age2, address2);

            Console.WriteLine("\nИнформация о людях:");
            person1.DisplayInfo();
            person2.DisplayInfo();

            Console.ReadLine();
        }
    }
}