using System;
using System.IO;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
           string allYourNumbers = ReadNumbersFromKeyboard();
           string yourSeparator = ReadSeparatorFromKeyboard();
           string resultedString="";
            int counter = 0;
           foreach(string userNumber in allYourNumbers.Split(" "))
            {
                if (counter < allYourNumbers.Split(" ").Count() - 1) { 
                
                    resultedString = resultedString + userNumber + yourSeparator;
                
                    counter = counter + 1;
                }
                else
                    resultedString = resultedString + userNumber;
            }

            Console.Write(resultedString);
        }

        static string ReadNumbersFromKeyboard()
        {

            Console.WriteLine("Type 10 numbers: ");

            string input = Console.ReadLine();
            if (input.Split(" " ).Count() > 1 || String.IsNullOrEmpty(input))
                return input;
            else
            {
                Console.WriteLine("Please insert at least 2 numbers");
                return ReadNumbersFromKeyboard();
            }
        }

        static string ReadSeparatorFromKeyboard()
        {

            Console.WriteLine("Type Your Separator: ");
            
            string separator= Console.ReadLine();

            if (!String.IsNullOrEmpty(separator))
                return separator;
            else
            {
                Console.WriteLine("Please insert at least 1 separator");
                return ReadSeparatorFromKeyboard();
            }

        }
    }
}
