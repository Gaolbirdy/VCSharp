using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace StringReader类
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter str = new StringWriter();
            str.WriteLine("Hello, this message is read by StringReader class");
            str.Close();

            StringReader reader = new StringReader(str.ToString());

            while (reader.Peek() > -1)
            {
                WriteLine(reader.Peek());
                WriteLine(reader.ReadLine());
            }
        }
    }
}
