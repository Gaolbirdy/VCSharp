using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace DirectoryInfo类
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DirectoryInfo directory = new DirectoryInfo(@"test\yiibai_dir");
    //        //DirectoryInfo directory = new DirectoryInfo(@"\test\yiibai_dir");
    //        try
    //        {
    //            if (directory.Exists)
    //            {
    //                WriteLine("Directory already exist.");
    //                return;
    //            }
    //            directory.Create();
    //            WriteLine("The directory is created successfully.");
    //        }
    //        catch (Exception e)
    //        {
    //            WriteLine("Directory not created: {0}", e.ToString());
    //        }

    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"test\yiibai_dir");
            try
            {
                directory.Delete();
                WriteLine("The directory is deleted successfully.");
            }
            catch (Exception e)
            {
                //WriteLine("Something went wrong: {0}",e.ToString());
                WriteLine("Something went wrong: {0}",e);
            }
        }
    }
}
