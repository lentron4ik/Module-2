using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // Конструктор
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        // Метод для вывода информации о человеке
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Адрес: {Address}");
        }
    }
}