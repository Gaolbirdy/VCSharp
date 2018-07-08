using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace TextWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("TextWriter.txt"))
            {
                writer.WriteLine("Hello C#, TextWriter");
                writer.WriteLine("C# File Handling by Yiibai.com");
            }
            WriteLine("Data written successfully...");
        }
    }
}
