using System;

namespace SwitchCaseStatement
{
    class Program
    {
        static void Main()
        {
            ShowCards(13);
        }
        static void ShowCards(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1:
                    goto case 13;
                default:
                    Console.WriteLine(cardNumber);
                    break;
            }
        }
    }
}
