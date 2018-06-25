using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 21;
            //int b = 10;
            //int c;

            //c = a + b;
            //WriteLine("Line 1 - Value of c is {0}", c);
            //c = a - b;
            //WriteLine("Line 2 - Value of c is {0}", c);
            //c = a * b;
            //WriteLine("Line 3 - Value of c is {0}", c);
            //c = a / b;
            //WriteLine("Line 4 - Value of c is {0}", c);
            //c = a % b;
            //WriteLine("Line 5 - Value of c is {0}", c);
            //c = a++;
            //WriteLine("Line 6 - Value of c is {0}", c);
            //c = a--;
            //WriteLine("Line 7 - Value of c is {0}", c);

            //if (a == b)
            //{
            //    WriteLine("Line 1 - a is equal to b");
            //}
            //else
            //{
            //    WriteLine("Line 1 - a is not equal to b");
            //}

            //if (a < b)
            //{
            //    WriteLine("Line 2 - a is less than b");
            //}
            //else
            //{
            //    WriteLine("Line 2 - a is not less than b");
            //}

            //if (a > b)
            //{
            //    WriteLine("Line 3 - a is greater than b");
            //}
            //else
            //{
            //    WriteLine("Line 3 - a is not greater than b");
            //}

            //a = 5;
            //b = 20;
            //if (a <= b)
            //{
            //    WriteLine("Line 4 - a is either less than or equal to b");
            //}
            //if (b >= a)
            //{
            //    WriteLine("Line 5 - b is either greater than or equal to a");
            //}

            //bool a = true;
            //bool b = true;

            //if (a && b)
            //{
            //    WriteLine("Line 1 - Condition is true");
            //}

            //if (a || b)
            //{
            //    WriteLine("Line 2 - Condition is true");
            //}

            //a = false;
            //b = true;

            //if (a && b)
            //{
            //    WriteLine("Line 3 - Condition is true");
            //}
            //else
            //{
            //    WriteLine("Line 3 - Condition is not true");
            //}

            //if (!(a&&b))
            //{
            //    WriteLine("Line 4 - Condition is true");
            //}

            //int a = 60;
            //int b = 13;
            //int c = 0;

            //c = a & b;
            //WriteLine("Line 1 - Value of c is {0}", c);

            //c = a | b;
            //WriteLine("Line 2 - Value of c is {0}", c);

            //c = a ^ b;
            //WriteLine("Line 3 - Value of c is {0}", c);

            //c = ~a;
            //WriteLine("Line 4 - Value of c is {0}", c);

            //c = a << 2;
            //WriteLine("Line 5 - Value of c is {0}", c);

            //c = a >> 2;
            //WriteLine("Line 6 - Value of c is {0}", c);

            //int a = 21;
            //int c;

            //c = a;
            //WriteLine("Line 1 - = Value of c = {0}", c);

            //c += a;
            //WriteLine("Line 2 - += Value of c = {0}", c);

            //c -= a;
            //WriteLine("Line 3 - -= Value of c = {0}", c);

            //c *= a;
            //WriteLine("Line 4 - *= Value of c = {0}", c);

            //c /= a;
            //WriteLine("Line 5 - /= Value of c = {0}", c);

            //c = 200;
            //c %= a;
            //WriteLine("Line 6 - %= Value of c = {0}", c);

            //c <<= 2;
            //WriteLine("Line 7 - <<= Value of c = {0}", c);

            //c >>= 2;
            //WriteLine("Line 8 - >>= Value of c = {0}", c);

            //c &= 2;
            //WriteLine("Line 9 - &= Value of c = {0}", c);

            //c ^= 2;
            //WriteLine("Line 10 - ^= Value of c = {0}", c);

            //c |= 2;
            //WriteLine("Line 11 - |= Value of c = {0}", c);

            //WriteLine("The size of int is {0}", sizeof(int));
            //WriteLine("The size of short is {0}", sizeof(short));
            //WriteLine("The size of double is {0}", sizeof(double));

            //int a, b;
            //a = 10;
            //b = (a == 1) ? 20 : 30;
            //WriteLine("Value of b is {0}", b);

            //b = (a == 10) ? 20 : 30;
            //WriteLine("Value of b is {0}", b);

            int a = 20;
            int b = 10;
            int c = 15;
            int d = 5;
            int e;

            e = (a + b) * c / d;
            WriteLine("Value of (a + b) * c / d is : {0}", e);

            e = ((a + b) * c) / d;
            WriteLine("Value of ((a + b) * c) / d is : {0} ", e);

            e = (a + b) * (c / d);
            WriteLine("Value of (a + b) * (c / d) is : {0}", e);

            e = a + (b * c) / d;
            WriteLine("Value of a + (b * c) / d is : {0}", e);

            ReadLine();
        }
    }
}
