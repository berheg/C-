using System;

namespace ChechPlindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr, reverseStr = ""; //string.Empty;
            Console.WriteLine("This is Palindrome Checker");
            Console.Write("Enter a string : ");
            inputStr = Console.ReadLine();
            if (inputStr != "")
            {
                int i = 0;
                int j = inputStr.length;
                Boolean flag = false;
                Console.WriteLine("Hello World!");
                Console.ReadKey();
                do
                {
                    reverseStr += inputStr[i];
                    if (inputStr[i] != reverseStr[i])
                        flag = true;
                    else
                    {
                        i++;
                        j++;
                    }
                } while ((i < inputStr.Length) && j >= 0 && flag);
                if (flag)
                {
                    Console.WriteLine("The character in" + i + "position in input is not the same as in reverse string");
                }
                else
                {
                    Console.WriteLine("It is palindrom");
                }
            }
            else
            {
                Console.WriteLine("You did not enter string!");
            }

            
        }
    }
}
