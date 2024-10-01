using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd5
{
    internal class zd5
    {
        static void Main(string[] args)
        {
            // Создаем экземпляры датчика температуры и термостата
            TemperatureSensor sensor = new TemperatureSensor();
            Thermostat thermostat = new Thermostat();

            // Подписываем термостат на событие изменения температуры в датчике
            sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

            // Ввод данных температуры
            while (true)
            {
                Console.Write("Введите температуру (или 'exit' для выхода): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (double.TryParse(input, out double temperature))
                {
                    // Устанавливаем новую температуру, это вызовет событие TemperatureChanged
                    sensor.Temperature = temperature;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, попробуйте еще раз.");
                }
            }
        }
    }
}