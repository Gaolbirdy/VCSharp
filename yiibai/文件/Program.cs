using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace FileIOApplication
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //FileStream f = new FileStream("sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

    //        FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
    //        for (int i = 1; i <= 20; i++)
    //        {
    //            f.WriteByte((byte)i);
    //        }

    //        f.Position = 0;
    //        for (int i = 0; i <= 20; i++)
    //        {
    //            Write(f.ReadByte() + " ");
    //        }
    //        f.Close();
    //    }
    //}

}

namespace FileApplication
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            // Create an instance of StreamReader to read from a file.
    //            // The using statement also closes the StreamReader.
    //            using (StreamReader sr = new StreamReader(@"D:\VCSharp\yiibai\文件\jamaica.txt"))
    //            {
    //                string line;

    //                while ((line = sr.ReadLine()) != null)
    //                {
    //                    WriteLine(line);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            WriteLine("The file could not be read:");
    //            WriteLine(e.Message);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] names = new string[] { "Max Su", "Sukida" };
    //        using (StreamWriter sw = new StreamWriter("all_names.txt"))
    //        {
    //            foreach (string s in names)
    //            {
    //                sw.WriteLine(s);
    //            }
    //        }

    //        string line = "";
    //        using (StreamReader sr = new StreamReader("all_names.txt"))
    //        {
    //            while ((line = sr.ReadLine()) != null)
    //            {
    //                WriteLine(line);
    //            }
    //        }
    //    }
    //}
}

//namespace BinaryFileApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BinaryWriter bw;
//            BinaryReader br;

//            int i = 25;
//            double d = 3.14157;
//            bool b = true;
//            string s = "I am happy";

//            try
//            {
//                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
//            }
//            catch (IOException e)
//            {
//                WriteLine(e.Message + "\n Cannot create file.");
//                return;
//            }

//            try
//            {
//                bw.Write(i);
//                bw.Write(d);
//                bw.Write(b);
//                bw.Write(s);
//            }
//            catch (IOException e)
//            {
//                WriteLine(e.Message + "\n Cannot write to file.");
//                return;
//            }
//            bw.Close();

//            try
//            {
//                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
//            }
//            catch (IOException e)
//            {
//                WriteLine(e.Message + "\n Cannot open file.");
//                return;
//            }

//            try
//            {
//                i = br.ReadInt32();
//                WriteLine("Integer data: {0}", i);

//                d = br.ReadDouble();
//                WriteLine("Double data: {0}", d);

//                b = br.ReadBoolean();
//                WriteLine("Boolean data: {0}", b);

//                s = br.ReadString();
//                WriteLine("String data: {0}", s);

//            }
//            catch (IOException e)
//            {
//                WriteLine(e.Message + "\n Cannot read from file.");
//                return;
//            }
//            br.Close();

//            ReadKey();
//        }
//    }
//}


namespace WindowsFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo mydir = new DirectoryInfo(@"F:\Steam");

            FileInfo[] f = mydir.GetFiles();

            foreach (FileInfo file in f)
            {
                WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
            }
        }
    }
}