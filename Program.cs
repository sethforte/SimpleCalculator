using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMessages.Greeting();
            Console.WriteLine();
            RequestData.DisplayMenu();


            Console.ReadLine();
        }
    }
}
