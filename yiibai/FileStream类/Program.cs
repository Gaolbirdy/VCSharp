using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace FileStream类
{
    public class FileStreamExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("filestream-demo.txt", FileMode.OpenOrCreate);
            //f.WriteByte(65);

            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();

            f = new FileStream("filestream-demo.txt", FileMode.OpenOrCreate);
            int j = 0;

            while ((j = f.ReadByte()) != -1)
            {
                Write((char)j);
            }
            f.Close();
        }
    }
}
