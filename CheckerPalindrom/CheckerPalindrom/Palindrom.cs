using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerPalindrom
{
    class Palindrom
    {
        private string inputStr, reverseStr ="";
        public Palindrom(string str)
        {
            this.inputStr = str;
        }
        public void IsPalindrom()
        {
            if (inputStr != "")
            {
                int i = 0;
                int j = inputStr.Length - 1;
                //flag used to break the loop 
                bool flag = false;
                do
                {
                    reverseStr += inputStr[j].ToString();
                    if (inputStr[i] != reverseStr[i])
                        flag = true;
                    else
                    {
                        i++;
                        j--;
                    }
                } while ((i < inputStr.Length) && j >= 0 && !flag);
                //if not palindrom
                if (flag)
                {
                    Console.WriteLine("The character at position {0} in", (i + 1));
                    Console.WriteLine("    input string: {0}", inputStr[i]);
                    Console.WriteLine("    reverse string: {0}", reverseStr[i]);
                    Console.WriteLine("So,It is not Palindrom!");
                }
                //if input is palindrom
                else
                {
                    Console.WriteLine("The reverse: {0}", reverseStr);
                    Console.WriteLine("It is palindrom");
                }
            }
            //if input is empty
            else
            {
                Console.WriteLine("You do not enter string!");
            }
        }

    }
}
