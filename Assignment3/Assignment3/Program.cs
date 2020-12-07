using System;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = ReadFirstStringFromKeyboard();
            string secondString = ReadSecondStringFromKeyboard();
            int counter = 0;
            
            foreach (string word in firstString.Split(" "))
            {

                if (secondString.Equals(word, StringComparison.InvariantCultureIgnoreCase))
                {
                    counter = counter + 1;
                }
            }

            Console.Write($"Your word is found {counter} time in your first string!");
        }



        static string ReadFirstStringFromKeyboard()
        {

            Console.WriteLine("Type your string: ");

            string readFirstString = Console.ReadLine();
            if (!String.IsNullOrEmpty(readFirstString))
                return readFirstString;
            else
            {
                Console.WriteLine("Please insert at least 1 word");
                return ReadFirstStringFromKeyboard();
            }
        }
        static string ReadSecondStringFromKeyboard()
        {

            Console.WriteLine("Type your string: ");

            string readSecondString = Console.ReadLine();
            if (!String.IsNullOrEmpty(readSecondString))
                return readSecondString;
            else
            {
                Console.WriteLine("Please insert at least 1 word");
                return ReadSecondStringFromKeyboard();
            }
        }
    }
}
