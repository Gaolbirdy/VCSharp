using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace FileApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                // 创建一个 StreamReader 的实例来读取文件
//                // using 语句也能关闭 StreamReader
//                using (StreamReader sr = new StreamReader(@"D:\VCSharp\RUNOOB\文件的输入与输出 文本文件的读写\bin\Debug\jamaica.txt"))
//                //using (StreamReader sr = new StreamReader("D:\\VCSharp\\RUNOOB\\文件的输入与输出 文本文件的读写\\bin\\Debug\\jamaica.txt"))
//                {
//                    string line;

//                    // 从文件读取并显示行，直到文件的末尾
//                    while ((line = sr.ReadLine()) != null)
//                    {
//                        Console.WriteLine(line);
//                    }
//                }

//            }
//            catch (Exception e)
//            {
//                // 向用户显示出错消息
//                Console.WriteLine("The file could not be read:");
//                Console.WriteLine(e.Message);
//            }
//            Console.ReadKey();
//        }
//    }
//}

namespace FileApplication
{
    class Program
    {
        static void Main()
        {
            string[] names = new string[] { "Zara Ali", "Nuha Ali", "Popo Liu"};
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // 从文件中读取并显示每行
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
