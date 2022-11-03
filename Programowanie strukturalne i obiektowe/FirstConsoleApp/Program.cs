using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World");
            Console.WriteLine("Hello World!");

            int number = 57;
            Console.WriteLine("Wartosc zmiennej to:  " + number);

            if (number == 5)
                Console.WriteLine("Równe");
            else
                Console.WriteLine("Nie są równe");
        }
    }
}
