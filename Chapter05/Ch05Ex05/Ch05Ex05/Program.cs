using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString1 = "A string";
            char myChar1 = myString1[2];
            //myString1[1] = "X";
            WriteLine(myChar1);
            WriteLine(myString1.Length);
            char[] myChars = myString1.ToCharArray();
            foreach(char charater in myChars)
            {
                WriteLine(charater);
            }

            string userResponse = ReadLine();
            char[] trimChar = { ' ', 'e', 's' };
            userResponse = userResponse.Trim(trimChar);
            if(userResponse.ToLower() == "y")
            {
                WriteLine("yes");
            }

            string myString = " This  is a test. ";
            char[] separator = {' '};
            string[] myWords;
            myWords = myString.Split(separator);
            WriteLine(myWords.Length);
            foreach (string word in myWords)
            {
                WriteLine(word);
            }
            ReadKey();
        }
    }
}
