using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "This is   text with   far  too   much   " +
                     "white space.";
            string pattern = "\\s+";
            string replacement = " ";
            string result = Regex.Replace(input, pattern, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
        }
    }
}
