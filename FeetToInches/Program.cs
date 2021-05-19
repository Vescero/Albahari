using System;   // Импорт пространства имён

namespace FeetToInches  // Объявление пространства имён
{
    class Program   // Объявление пространства имён
    {
        static void Main()  // Объявление метода Main
        {
            /* Блок операторов */
            Console.WriteLine(FeetToInches(30));    // Оператор 1
            Console.WriteLine(FeetToInches(100));   // Оператор 2
            /* Конец блока операторов */
        }
        private static int FeetToInches(int feet)   // Объявление приватного метода FeetToInches
        {
            /* Блок операторов */
            int inches = feet * 12; // Литерал 12 умножается на пареметр получаемый методом
            return inches;          // Передача выходных данных из идентификатора типа int (inches) вызывающему коду
            /* Конец блока операторов */
        }
    }
}
