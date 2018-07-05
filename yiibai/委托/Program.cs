using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

delegate int NumberChanger(int n);

namespace DelegateAppl
{
    //class TestDelegate
    //{
    //    static int num = 100;

    //    public static int AddNum(int p)
    //    {
    //        num += p;
    //        return num;
    //    }

    //    public static int MultNum(int q)
    //    {
    //        num *= q;
    //        return num;
    //    }

    //    public static int GetNum()
    //    {
    //        return num;
    //    }

    //    static void Main(string[] args)
    //    {
    //        NumberChanger nc;
    //        NumberChanger nc1 = new NumberChanger(AddNum);
    //        NumberChanger nc2 = new NumberChanger(MultNum);

    //        nc = nc1;
    //        nc += nc2;

    //        //nc = nc2;
    //        //nc += nc1;
    //        nc(5);

    //        //nc1(10);
    //        //nc1(15);
    //        //WriteLine("Value of Num: {0}", GetNum());
    //        //nc2(5);
    //        WriteLine("Value of Num: {0}", GetNum());

    //        ReadKey();
    //    }
    //}   

    class Program
    {
        static FileStream fs;
        static StreamWriter sw;

        public delegate void PrintString(string s);

        public static void WriteToScreen(string str)
        {
            WriteLine("The String is: {0}", str);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(PrintString ps)
        {
            ps("Hello world");
        }

        static void Main(string[] args)
        {
            PrintString ps1 = new PrintString(WriteToScreen);
            PrintString ps2 = new PrintString(WriteToFile);

            SendString(ps1);
            SendString(ps2);

            ReadKey();
        }
    }
}
