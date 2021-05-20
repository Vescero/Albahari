using System;                       // Подлкючение простраства имён

namespace InstanceVSStaticMembers   // Объявление пространства имён
{
    class Program                   // Объявление класса Program
    {
        static void Main()          // Объявление метода Main
        {
            Panda panda1 = new Panda("Pan Dee");    // Создание экземпляра класса Panda и присваивание значение name 
            Panda panda2 = new Panda("Pan Dah");    
            Console.WriteLine($" Первую панду зовут: {panda1.Name}\n Вторую панду зовут: {panda2.Name}\n Всего панд: {Panda.Population}");  // Вывод на экран
            Console.ReadKey();
        }                           // Конец объявления метода Main
    }                               // Конец объявления класса Program

    public class Panda              // Объявление класса Panda
    {
        public string Name;             // Поле экземпляра класса
        public static int Population;   // Статическое поле, имеет дело с самим классом
        public Panda (string name) { Name = name; Population++; }   // Присваиваем значение полю экземпляра, инкрементируем значение статического поля
    }                               // Конец объявления класса Panda
}                                   // Конец объявления пространства имён
