using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//
namespace EmailChecker
{
    class InputString
    {
        private string inputStr;
        public InputString(string str)
        {
            this.inputStr = str;
        }
        public void EmailChecker()
        {
            string pattern = @"[a-zA-z0-9_.+-]+@[a-zA-z0-9-]" +
                "+\\.[a-zA-z0-9-]+.?[a-zA-z0-9-]";
            string replacement = "Email";
            string result = Regex.Replace(inputStr, pattern, replacement);
            Console.WriteLine("Original String: {0}", inputStr);
            Console.WriteLine("Replacement String: {0}", result);
        }
    }
}
