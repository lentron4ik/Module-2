using System;

namespace Bap1_zd2
{
    // Структура "train"
    public struct Train
    {
        public string Destination { get; set; }
        public int TrainNumber { get; set; }
        public DateTime DepartureTime { get; set; }

        // Конструктор структуры train
        public Train(string destination, int trainNumber, DateTime departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }

        // Метод для вывода информации о поезде
        public void DisplayInfo()
        {
            Console.WriteLine($"Пункт назначения: {Destination}, Номер поезда: {TrainNumber}, Время отправления: {DepartureTime.ToShortTimeString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Массив для хранения данных о поездах
            Train[] trains = new Train[5];

            // Ввод данных о поездах
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"\nВведите данные для поезда {i + 1}:");

                // Ввод пункта назначения
                Console.Write("Пункт назначения: ");
                string destination = Console.ReadLine();

                // Ввод номера поезда
                Console.Write("Номер поезда: ");
                int trainNumber;
                while (!int.TryParse(Console.ReadLine(), out trainNumber))
                {
                    Console.WriteLine("Ошибка! Введите корректный номер поезда:");
                }

                // Ввод времени отправления
                Console.Write("Время отправления (формат ЧЧ:ММ): ");
                DateTime departureTime;
                while (!DateTime.TryParse(Console.ReadLine(), out departureTime))
                {
                    Console.WriteLine("Ошибка! Введите корректное время (ЧЧ:ММ):");
                }

                // Создание поезда и добавление в массив
                trains[i] = new Train(destination, trainNumber, departureTime);
            }

            // Сортировка по номерам поездов
            Array.Sort(trains, CompareByTrainNumber);

            Console.WriteLine("\nПоезда, отсортированные по номерам:");
            foreach (var train in trains)
            {
                train.DisplayInfo();
            }

            // Вывод информации о поезде по номеру
            Console.Write("\nВведите номер поезда для поиска: ");
            int searchNumber = int.Parse(Console.ReadLine());
            bool trainFound = false;

            foreach (var train in trains)
            {
                if (train.TrainNumber == searchNumber)
                {
                    train.DisplayInfo();
                    trainFound = true;
                    break;
                }
            }

            if (!trainFound)
            {
                Console.WriteLine("Поезд с таким номером не найден.");
            }

            // Сортировка по пункту назначения и времени отправления
            Array.Sort(trains, CompareByDestinationAndTime);

            Console.WriteLine("\nПоезда, отсортированные по пункту назначения и времени отправления:");
            foreach (var train in trains)
            {
                train.DisplayInfo();
            }

            Console.ReadLine(); // Ожидание завершения программы
        }

        // Метод для сравнения поездов по номеру
        static int CompareByTrainNumber(Train t1, Train t2)
        {
            return t1.TrainNumber.CompareTo(t2.TrainNumber);
        }

        // Метод для сравнения поездов по пункту назначения и времени отправления
        static int CompareByDestinationAndTime(Train t1, Train t2)
        {
            int destinationComparison = t1.Destination.CompareTo(t2.Destination);
            if (destinationComparison != 0)
            {
                return destinationComparison;
            }
            return t1.DepartureTime.CompareTo(t2.DepartureTime);
        }
    }
}