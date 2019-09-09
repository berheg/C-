using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//uses Palindrom class
namespace CheckerPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            Console.WriteLine("This is Palindrome Checker");
            Console.Write("Enter a string : ");
            inputStr = Console.ReadLine();
            var stringValue = new Palindrom(inputStr);
            stringValue.IsPalindrom();
        }
    }
}
