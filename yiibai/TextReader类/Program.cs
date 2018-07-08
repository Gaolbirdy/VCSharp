using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace TextReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("TextWriter.txt"))
            {
                WriteLine(tr.ReadToEnd());
            }
            WriteLine();

            using (TextReader tr = File.OpenText("TextWriter.txt"))
            {
                WriteLine(tr.ReadLine());
            }
        }
    }
}
