using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using static System.Console;

namespace Ch18Ex00
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileInfo = @"D:\VCSharp\Chapter18\Ch18Ex00\log.txt";
            //FileInfo aFile = new FileInfo(fileInfo);
            ////FileInfo aFile = new FileInfo("Data.txt");
            //aFile.Create();
            //if (aFile.Exists)
            //    WriteLine("File Exists");
            //else
            //    WriteLine("File No Exists");

            //if (File.Exists(fileInfo))
            //    WriteLine("File Exists");
            //else
            //    WriteLine("File No Exists");

            FileStream aFile = new FileStream(fileInfo,FileMode.Create,FileAccess.ReadWrite);
            aFile.Seek(8, SeekOrigin.Begin);
            aFile.Seek(2, SeekOrigin.Current);
            aFile.Seek(-5, SeekOrigin.End);

            ReadKey();
        }
    }
}
