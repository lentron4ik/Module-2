using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3
{
    public class Author
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Author(string name, int birthYear) // конструктор
        {
            Name = name;
            BirthYear = birthYear;
        }

        // Метод для получения информации об авторе
        public override string ToString()
        {
            return $"{Name}, родился в {BirthYear} году";
        }
    }
}
