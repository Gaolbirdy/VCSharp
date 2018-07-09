using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace StringWriter类
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, Welcome to the yiibai.com \n" +
                "It is nice site. \n" +
                "It provides IT tutorials";

            // Creating StringBuilder instance
            StringBuilder sb = new StringBuilder();

            // Passing StringBuilder instance into StringWriter
            StringWriter writer = new StringWriter(sb);

            // Writing data using StringWriter
            writer.WriteLine(text);
            writer.Flush();

            // Closing writer connection
            writer.Close();

            // Creating StringReader instance and passing StringBuilder
            StringReader reader = new StringReader(sb.ToString());

            while (reader.Peek() > -1)
            {
                WriteLine(reader.Peek());
                WriteLine(reader.ReadLine());
            }
        }
    }
}
