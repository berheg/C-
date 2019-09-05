using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmailChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Girmay emailn inkght@yahoo.com.,Tollosa emailn: wertyu@gmail.com." +
                     " Getch emailn: fghty@ethiotel.net.";
            string pattern = @"[a-zA-z0-9_.+-]+@[a-zA-z0-9-]"+
                "+\\.[a-zA-z0-9-]+.?[a-zA-z0-9-]";
            string replacement = "Email";
            string result = Regex.Replace(input, pattern, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
        }
    }
}
