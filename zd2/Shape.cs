using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    public abstract class Shape
    {
        /*абстракция обозначает что метод не имеет реализации в данном (родительском) классе.
         Все дочерние классы будут должны предоставить свою собственную реализацию этого метода. Это как "заготовка", которую наследники обязаны заполнить.
         Абстрактные методы могут существовать только в абстрактных классах.
         */
        // метод для вычисления площади
        public abstract double Area(); 

        // метод для вычисления периметра
        public abstract double Perimeter();
    }
}