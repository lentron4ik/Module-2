using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd5
{
    public class Thermostat
    {

        private const double MinTemperature = 5.0;
        private const double MaxTemperature = 20.0;

        // Метод для обработки изменения температуры
        // Метод для обработки события изменения температуры
        public void OnTemperatureChanged(double temperature)
        {
            if (temperature < MinTemperature)
            {
                Console.WriteLine($"Температура {temperature}°C: Включаем отопление.");
            }
            else if (temperature > MaxTemperature)
            {
                Console.WriteLine($"Температура {temperature}°C: Выключаем отопление.");
            }
            else
            {
                Console.WriteLine($"Температура {temperature}°C: Температура в норме.");
            }
        }
    }
}
