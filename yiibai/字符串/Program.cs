using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StringApplication
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string fname, lname;
    //        fname = "Rowan";
    //        lname = "Atkinson";

    //        string fullname = fname + lname;
    //        WriteLine("Full Name: {0}", fullname);

    //        char[] letters = { 'H', 'e', 'l', 'l', 'o' };
    //        string greetings = new string(letters);
    //        WriteLine("Greetings: {0}", greetings);

    //        string[] sarray = { "Hello", "From", "Yiibai", "Point" };
    //        string message = String.Join(" ", sarray);
    //        WriteLine("Message: {0}", message);

    //        DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
    //        string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
    //        WriteLine("Message: {0}", chat);


    //    }
    //}

    class StringProg
    {
        //static void Main(string[] args)
        //{
        //    string str1 = "This is test";
        //    string str2 = "This is text";

        //    if (String.Compare(str1, str2) == 0)
        //    {
        //        WriteLine(str1 + " and " + str2 + " are equal.");
        //    }
        //    else
        //    {
        //        WriteLine(str1 + " and " + str2 + " are not equal.");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    string str = "This is test";
        //    if (str.Contains("test"))
        //    {
        //        WriteLine("The sequence 'test' was found.");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    string str = "Last night I dreamt of Girls";
        //    WriteLine(str);
        //    string substr = str.Substring(23);
        //    WriteLine(substr);
        //}

        static void Main(string[] args)
        {
            string[] starray = new string[] {"Down the way nights are dark",
         "And the sun shines daily on the mountain top",
         "I took a trip on a sailing ship",
         "And when I reached Jamaica",
         "I made a stop"};

            string str = String.Join("\n", starray);
            WriteLine(str);
        }
    }
}
