using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculations
    {
        public static double Add()
        {
            Console.Clear();
            Console.WriteLine("Please enter the first number:");
            string xText = Console.ReadLine();
            bool isValidNumber = double.TryParse(xText, out double x);

            Console.WriteLine("Please enter the second number:");
            string yText = Console.ReadLine();
            bool isValidNumber2 = double.TryParse(yText, out double y);

             double output = x + y;

            Console.WriteLine($"{x} + {y} = {output}.");
            Console.WriteLine("Would you like to make another calculation?(yes/no)");

            string choice = Console.ReadLine();
            if (choice.Equals("yes"))
            {
                RequestData.DisplayMenu();
            }
            else
            {
                UserMessages.EndMessage();
            }
            return output;
        }

        public static double Subtract()
        {
            Console.Clear();
            Console.WriteLine("Please enter the first number:");
            string xText = Console.ReadLine();
            bool isValidNumber = double.TryParse(xText, out double x);

            Console.WriteLine("Please enter the second number:");
            string yText = Console.ReadLine();
            bool isValidNumber2 = double.TryParse(yText, out double y);

            double output = x - y;

            Console.WriteLine($"{x} - {y} = {output}.");
            Console.WriteLine("Would you like to make another calculation?(yes/no)");

            string choice = Console.ReadLine();
            if (choice.Equals("yes"))
            {
                RequestData.DisplayMenu();
            }
            else
            {
                UserMessages.EndMessage();
            }
            return output;
        }

        public static double Multiply()
        {
            Console.Clear();
            Console.WriteLine("Please enter the first number:");
            string xText = Console.ReadLine();
            bool isValidNumber = double.TryParse(xText, out double x);

            Console.WriteLine("Please enter the second number:");
            string yText = Console.ReadLine();
            bool isValidNumber2 = double.TryParse(yText, out double y);

            double output = x * y;

            Console.WriteLine($"{x} * {y} = {output}.");
            Console.WriteLine("Would you like to make another calculation?(yes/no)");

            string choice = Console.ReadLine();
            if (choice.Equals("yes"))
            {
                RequestData.DisplayMenu();
            }
            else
            {
                UserMessages.EndMessage();
            }
            return output;
        }

        public static double Divide()
        {
            Console.Clear();
            Console.WriteLine("Please enter the first number:");
            string xText = Console.ReadLine();
            bool isValidNumber = double.TryParse(xText, out double x);

            Console.WriteLine("Please enter the second number:");
            string yText = Console.ReadLine();
            bool isValidNumber2 = double.TryParse(yText, out double y);

            double output = x / y;

            Console.WriteLine($"{x} / {y} = {output}.");
            Console.WriteLine("Would you like to make another calculation?(yes/no)");

            string choice = Console.ReadLine();
            if (choice.Equals("yes"))
            {
                RequestData.DisplayMenu();
            }
            else
            {
                UserMessages.EndMessage();
            }
            return output;


        }
    }
}
