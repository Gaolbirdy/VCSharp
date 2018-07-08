using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace StreamReader类
{
    public class StreamReaderExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("myoutput.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            //string line = s.ReadLine();
            //WriteLine(line);
            //string line2 = s.ReadLine();
            //WriteLine(line2);

            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                WriteLine(line);
            }

            s.Close();
            f.Close();
        }
    }
}
