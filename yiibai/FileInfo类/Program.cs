using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace FileInfo类
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            string loc = "fileinfo.txt";
    //            FileInfo file = new FileInfo(loc);

    //            StreamWriter sw = file.CreateText();
    //            sw.WriteLine("This text is written to the file by using StreamWriter class.");
    //            sw.Close();

    //            WriteLine("File is created successfully");
    //        }
    //        catch (IOException e)
    //        {

    //            WriteLine("Something went wrong: " + e);
    //        }
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "fileinfo.txt";
                FileInfo file = new FileInfo(loc);
                StreamReader sr = file.OpenText();
                string data = "";
                while ((data = sr.ReadLine()) != null)
                {
                    WriteLine(data);
                }
            }
            catch (IOException e)
            {

                WriteLine("Something went wrong: " + e);
            }
        }
    }
}
