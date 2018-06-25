using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;

            //if (a < 10)
            //{
            //    WriteLine("a is less than 10");
            //}
            //WriteLine("value of a is : {0}", a);

            //int a = 199;

            //if (a < 10)
            //{
            //    WriteLine("a is less than 10");
            //}
            //else
            //{
            //    WriteLine("a is not less than 10");
            //}
            //WriteLine("value of a is : {0}", a);

            //int a = 199;

            //if (a == 19)
            //{
            //    WriteLine("Value of a is 19");
            //}
            //else if (a == 29)
            //{
            //    WriteLine("Value of a is 29");
            //}
            //else if (a == 39)
            //{
            //    WriteLine("Value of a is 39");
            //}
            //else
            //{
            //    WriteLine("None of the values is matching");
            //}
            //WriteLine("Exact value of a is :  {0}", a);

            //int a = 199;
            //int b = 299;

            //if (a == 199)
            //{
            //    if (b == 299)
            //    {
            //        WriteLine("Value of a is 199 and b is 299");
            //    }
            //}
            //WriteLine("Exact value of a is : {0}", a);
            //WriteLine("Exact value of b is : {0}", b);

            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    WriteLine("Well done");
                    break;
                case 'D':
                    WriteLine("You passed");
                    break;
                case 'F':
                    WriteLine("Better try again");
                    break;
                default:
                    WriteLine("Invalid grade");
                    break;
            }
            WriteLine("Your grade is {0}", grade);

            ReadLine();
        }
    }
}
