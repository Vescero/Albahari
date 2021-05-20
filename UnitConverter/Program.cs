using System;                                       // Подключение пространства имён

namespace UnitConverter                             // Объявление пространсва имён
{
    class Program                                   // Объявление класса  Program
    {
        static void Main()                          // Объявление метода Main
        {
            /* Блок операторов */
            UnitConverter feetToInchesConverter = new UnitConverter(12);    // Вызов конструктора и создание нового экземпляра для конвертации едениц и присваивание ему значения 12
            UnitConverter milesToFeeetConverter = new UnitConverter(5280);  // 5280

            Console.WriteLine(feetToInchesConverter.Convert(30));   // 30 * 12 = 360
            Console.WriteLine(feetToInchesConverter.Convert(100));  // 30 * 12 = 1200
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeeetConverter.Convert(1))); // (milestofeet(1))5280 * (feettoinches) 12 = 63360
            /* Конец блока операторов */
        }                                           // Конец объявления метода Main
    }                                               // Конец объявление класса Program
    public class UnitConverter                      // Объявление класса UnitConverter
    {
        int ratio;  // Поле для храненения значения
        public UnitConverter (int unitRatio) { ratio = unitRatio; }     // Конструктор принимающий значение коэфициента и присваювающий это значение полю ratio
        public int Convert(int unit) { return unit * ratio; }           // Метод принимающий введенное значение и умножающий это значение на значение переменной ratio
    }                                               // Конец объявления класса UnitConverter
}                                                   // Конец объявления пространства имён
