using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static string ReadFirstStringFromKeyboard()
        {

            Console.WriteLine("Type 10 numbers: ");

            string input = Console.ReadLine();
            if (input.Split(" ").Count() > 1 || String.IsNullOrEmpty(input))
                return input;
            else
            {
                Console.WriteLine("Please insert at least 2 numbers");
                return ReadNumbersFromKeyboard();
            }
        }
    }
}
