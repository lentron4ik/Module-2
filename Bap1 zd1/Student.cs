using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bap1_zd1
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Average { get; set; } // Средний балл

        // Конструктор класса "Студент"
        public Student(string firstName, string lastName, int age, double average)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            this.Average = average;
        }

        // Метод для вывода информации о студенте
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {FirstName}, Фамилия: {LastName}, Возраст: {Age}, Средний балл: {Average:F2}");
        }
    }
}
