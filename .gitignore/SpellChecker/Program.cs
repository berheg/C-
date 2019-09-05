using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpellChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input");
            string inputStr = Console.ReadLine().ToString();
            string letters = "abcdefghijklmnopqrstuvwxyz";
            int totalLength =  2 * inputStr.Length * letters.Length+inputStr.Length+letters.Length - 1;
            string [] newGeneratedWords=new string[(int)totalLength];
            Console.WriteLine("Total length: {0}", newGeneratedWords.Length);
            //delete a letter a given position
            string[] wordsByDelete = new string[inputStr.Length];
            string[] wordsBySwap = new string[inputStr.Length-1];
            string[] wordsByInsert = new string[(inputStr.Length+1)*letters.Length];
            string[] wordsByReplace = new string[(inputStr.Length+1)*(letters.Length-inputStr.Length)];
            int lengthDelete = 0;
            int totalIndex = 0;
            Console.WriteLine("Words generated by delete: ");
            for (int i = 0; i < inputStr.Length; i++)
            {
                newGeneratedWords[totalIndex] = inputStr.Remove(i, 1); 
                wordsByDelete[i] = inputStr.Remove(i, 1);
                totalIndex++;
                //Console.WriteLine(newGeneratedWords[i]);
                Console.WriteLine(wordsByDelete[i]);
            }
            lengthDelete = inputStr.Length;
            Console.WriteLine("The number of words generated using delete letter: {0}.", lengthDelete);
            Console.WriteLine("The totalIndex: {0}.", totalIndex);

            //Insert a letter at given position
            int lengthInsert=0;          
            for (int i = 0; i <= inputStr.Length; i++)
            {
                for(int j = 0; j < letters.Length; j++)
                {
                    newGeneratedWords[totalIndex] = inputStr.Insert(i, letters[j].ToString());
                    wordsByInsert[(i + 1) * j] = inputStr.Insert(i, letters[j].ToString());
                    totalIndex++;
                }
                lengthInsert = (inputStr.Length+1) *letters.Length;                
            }
            Console.WriteLine("The number of words generated using Insert: {0}.", lengthInsert);
            Console.WriteLine("The totalIndex: {0}.", totalIndex);
            //Swap two adjust letters
            int lengthSwap = 0;
            String swapStr = "";
            Console.WriteLine("Words generated by swap: ");
            for (int i = 0; i < inputStr.Length - 1; i++)
            {
                Char temp = inputStr[i];
                swapStr=inputStr.Remove(i, 1);
                swapStr=swapStr.Insert(i + 1, temp.ToString());               
                newGeneratedWords[totalIndex] = swapStr;
                wordsBySwap[i] = swapStr;
                totalIndex++;
                Console.WriteLine(swapStr);
            }
            lengthSwap = inputStr.Length - 1;
            Console.WriteLine("The total words generated by swap: {0}.", lengthSwap);
            Console.WriteLine("Length after swap: {0}", totalIndex);
            //Replace a letter in  a string given position with one letter of alphabets
            //int lengthReplace =0;
            int realLength = 0,checker =0;//index = 0
            for (int i = 0; i < inputStr.Length; i++)
            {
                string tempStr = inputStr.Remove(i, 1);
                for (int j = 0; j < letters.Length; j++)
                {
                    if (inputStr[i] != letters[j])
                    {
                        //index = (newLength - 1) + (i + 1) * (realLength + 1 - i);
                        
                        newGeneratedWords[totalIndex] = tempStr.Insert(i, letters[j].ToString());
                        wordsByReplace[realLength] = tempStr.Insert(i, letters[j].ToString());
                        checker = realLength;                       
                        totalIndex++;
                        realLength++;                     
                        
                    }            
                }        
            }
            Console.WriteLine("The number of words generated using Replace: {0}.", realLength);
            Console.WriteLine("Length after replace: {0}", totalIndex);
        }
    }
}