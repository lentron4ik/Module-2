using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3
{
    public class Book
    {
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public Author BookAuthor { get; set; } // Объект Author является частью Book (это композиция)

        public Book(string title, int yearPublished, Author author)
        {
            Title = title;
            YearPublished = yearPublished;
            BookAuthor = author;
        }

        // Метод для получения информации о книге
        public override string ToString()
        {
            return $"\"{Title}\", выпущена в {YearPublished} году, Автор: {BookAuthor}";
        }
    }
}
