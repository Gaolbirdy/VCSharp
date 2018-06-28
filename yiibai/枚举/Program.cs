using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnumApplication
{
    //class EnumProgram
    //{
    //    enum Days
    //    {
    //        Sun,
    //        Mon,
    //        Tue,
    //        Wed,
    //        Thu,
    //        Fri,
    //        Sat
    //    }

    //    static void Main(string[] args)
    //    {
    //        int WeekdayStart = (int)Days.Mon;
    //        int WeekdayEnd = (int)Days.Fri;
    //        WriteLine("Monday: {0}", WeekdayStart);
    //        WriteLine("Friday: {0}", WeekdayEnd);
    //    }
    //}

    //public class EnumExample
    //{
    //    public enum Season
    //    {
    //        WINTER = 10,
    //        SPRING,
    //        SUMMER,
    //        FALL
    //    }

    //    public static void Main()
    //    {
    //        int x = (int)Season.WINTER;
    //        int y = (int)Season.SUMMER;
    //        WriteLine("WINTER = {0}", x);
    //        WriteLine("SUMMER = {0}", y);
    //    }
    //}

    public class EnumExample
    {
        public enum Days
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        }

        public static void Main()
        {
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                WriteLine(s);
            }

            foreach (Days d in Enum.GetValues(typeof(Days)))
            {
                WriteLine(d);
            }

            foreach (int x in Enum.GetValues(typeof(Days)))
            {
                WriteLine(x);
            }
        }
    }
}
