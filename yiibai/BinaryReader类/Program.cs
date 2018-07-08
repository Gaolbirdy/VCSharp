using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace BinaryReader类
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            ReadKey();
        }

        static void WriteBinaryFile()
        {
            using (BinaryWriter writer =new BinaryWriter(File.Open("binaryfile.dat",FileMode.Create)))
            {
                writer.Write(250.01);
                writer.Write("this is string data");
                writer.Write(true);
            }
        }

        static void ReadBinaryFile()
        {
            using (BinaryReader reader =new BinaryReader(File.Open("binaryfile.dat",FileMode.Open)))
            {
                //WriteLine("Double value : " + reader.ReadInt32());
                WriteLine("Double value : " + reader.ReadDouble());
                WriteLine("String value : " + reader.ReadString());
                //WriteLine("Boolean value : " + reader.ReadChar());
                WriteLine("Boolean value : " + reader.ReadBoolean());
            }
        }
    }
}
