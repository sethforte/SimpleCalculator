using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class RequestData
    {

        public static void DisplayMenu()
        {
            Console.WriteLine("******************************");
            //Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine("5) Exit");
            Console.WriteLine("******************************");
            Console.Write("\r\nSelect an option: ");
            
            Console.WriteLine();



            string selectionText = Console.ReadLine();
            bool isValidSelection = int.TryParse(selectionText, out int selection);
            


            if (selection == 1)
            {
                Calculations.Add();
            }
            else if (selection == 2)
            {
                Calculations.Subtract();
            }
            else if (selection == 3)
            {
                Calculations.Multiply();
            }
            else if (selection == 4)
            {
                Calculations.Divide();
            }
            else if (selection == 5)
            {
                UserMessages.EndMessage();
            }


            } 
            


        }


    }

