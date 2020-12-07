using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter your word: ");
            string yourString = Console.ReadLine();

            if (getStatus(yourString))
            {
                Console.WriteLine($"{yourString} is a palindrome word!!");
            }
            else
            {
                Console.WriteLine($"{yourString} is not a palindrome word!!");
            }
        }


        public static bool getStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}
