using System;

namespace OutParamsSplit
{
    class Program
    {
        static void Main()
        {
            Split("Steeve Ray Vaughan", out string a, out string b);
            Console.WriteLine("First Name: "+a);
            Console.WriteLine("Last Name: "+b);
        }
        static void Split(string name, out string firstName, out string lastName)
        {
            Console.WriteLine(name);
            int i = name.LastIndexOf(" ");
            firstName = name.Substring(0,i);
            lastName = name.Substring(i + 1);
        }
    }
}
