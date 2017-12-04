using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace 文件的输入与输出
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                FileStream f = new FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
//            }
//            catch (FileNotFoundException e)
//            {
//                Console.WriteLine(e);
//            }
//            Console.ReadKey();
//        }
//    }
//}

namespace FileIOApplication
{
    class Program
    {
        static void Main()
        {
            FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                f.WriteByte((byte)i);
            }

            Console.WriteLine("f.Position: {0}", f.Position);

            f.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write((f.ReadByte() + " "));
            }

            f.Close();
            Console.ReadKey();
        }
    }
}