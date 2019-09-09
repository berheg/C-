﻿using System;

public class GenerateWords
{
    public string inputStr;
    public int lengthDelete = 0;
    public int lengthInsert = 0;
    public int lengthSwap = 0;
    public int totalIndex = 0;
    public string letters = "abcdefghijklmnopqrstuvwxyz";
    public int totalLength = 2 * inputStr.Length * letters.Length + inputStr.Length + letters.Length - 1;
    public string[] newGeneratedWords = new string[(int)totalLength];
    public string[] wordsByDelete = new string[inputStr.Length];
    public string[] wordsBySwap = new string[inputStr.Length - 1];    
    public string[] wordsByInsert = new string[(inputStr.Length + 1) * letters.Length];
    public string[] wordsByReplace = new string[(inputStr.Length + 1) * (letters.Length - inputStr.Length)];
    public GenerateWords(string str)
    {
        this.inputStr = str;
    }
    public CreatWordsByDelete()
	{
         
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

    }
  public CreatWordsByInsert()
    {
        //Insert a letter at given position        
        for (int i = 0; i <= inputStr.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                newGeneratedWords[totalIndex] = inputStr.Insert(i, letters[j].ToString());
                wordsByInsert[(i + 1) * j] = inputStr.Insert(i, letters[j].ToString());
                totalIndex++;
            }
            lengthInsert = (inputStr.Length + 1) * letters.Length;
        }
        Console.WriteLine("The number of words generated using Insert: {0}.", lengthInsert);
        Console.WriteLine("The totalIndex: {0}.", totalIndex);
    }
    public CreateWordsBySwap()
    {
        //Swap two adjust letters        
        String swapStr = "";
        Console.WriteLine("Words generated by swap: ");
        for (int i = 0; i < inputStr.Length - 1; i++)
        {
            Char temp = inputStr[i];
            swapStr = inputStr.Remove(i, 1);
            swapStr = swapStr.Insert(i + 1, temp.ToString());
            newGeneratedWords[totalIndex] = swapStr;
            wordsBySwap[i] = swapStr;
            totalIndex++;
            Console.WriteLine(swapStr);
        }
        lengthSwap = inputStr.Length - 1;
        Console.WriteLine("The total words generated by swap: {0}.", lengthSwap);
        Console.WriteLine("Length after swap: {0}", totalIndex);
    }
    public CreateWordsByReplace()
    {
        //Replace a letter in  a string given position with one letter of alphabets
        //int lengthReplace =0;
        int realLength = 0, checker = 0;//index = 0
        for (int i = 0; i < inputStr.Length; i++)
        {
            string tempStr = inputStr.Remove(i, 1);
            for (int j = 0; j < letters.Length; j++)
            {
                if (inputStr[i] != letters[j])
                {                  
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

