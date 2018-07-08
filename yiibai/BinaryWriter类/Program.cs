using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace BinaryWriter类
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "binaryfile.dat";

            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName,FileMode.Create)))
            {
                writer.Write(1024);
                writer.Write("this is string data");
                Write(true);
            }
            WriteLine("Data written successfully...");
        }
    }
}
