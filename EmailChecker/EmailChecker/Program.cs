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
            var pharagraph = new InputString(input);
            pharagraph.EmailChecker();
        }
    }
}
