using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个 DirectoryInfo 对象
            DirectoryInfo myDir = new DirectoryInfo(@"f:\Steam");

            // 获取目录中的文件以及它们的名称和大小
            FileInfo[] f = myDir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0}  Size: {1}", file.Name, file.Length);
            }
            Console.ReadKey();
        }
    }
}
