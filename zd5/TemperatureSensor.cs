using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd5
{
    public class TemperatureSensor
    {
        public delegate void TemperatureChangedEventHandler(double newTemperature);

        private double _temperature;

        // Событие, которое будет срабатывать при изменении температуры
        public event TemperatureChangedEventHandler TemperatureChanged;

        // Свойство Temperature, которое вызывает событие при изменении
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    // Генерация события TemperatureChanged
                    OnTemperatureChanged(_temperature);
                }
            }
        }

        // Метод для вызова события
        protected virtual void OnTemperatureChanged(double newTemperature)
        {
            TemperatureChanged?.Invoke(newTemperature); // Если на событие есть подписчики, оно вызывается
        }
    }
}
