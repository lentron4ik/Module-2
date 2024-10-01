using System;

namespace zd3
{
    internal class zd3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя первого автора: ");
            string author1Name = Console.ReadLine();

            Console.Write("Введите год рождения первого автора: ");
            int author1Year = int.Parse(Console.ReadLine());

            // Создание первого объекта Author
            Author author1 = new Author(author1Name, author1Year);

            Console.Write("Введите название первой книги: ");
            string book1Title = Console.ReadLine();

            Console.Write("Введите год выпуска первой книги: ");
            int book1Year = int.Parse(Console.ReadLine());

            // Создание первого объекта Book
            Book book1 = new Book(book1Title, book1Year, author1);

            Console.Write("\nВведите имя второго автора: ");
            string author2Name = Console.ReadLine();

            Console.Write("Введите год рождения второго автора: ");
            int author2Year = int.Parse(Console.ReadLine());

            // Создание второго объекта Author
            Author author2 = new Author(author2Name, author2Year);

            Console.Write("Введите название второй книги: ");
            string book2Title = Console.ReadLine();

            Console.Write("Введите год выпуска второй книги: ");
            int book2Year = int.Parse(Console.ReadLine());

            // Создание второго объекта Book
            Book book2 = new Book(book2Title, book2Year, author2);

            // Вывод информации о книгах и их авторах
            Console.WriteLine("\nИнформация о книгах:");
            Console.WriteLine(book1);
            Console.WriteLine(book2);
        }
    }
}