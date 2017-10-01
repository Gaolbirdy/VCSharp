using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch07Test04
{
    enum Orientation : byte
    {
        North=1,
        South=2,
        East=3,
        West=4
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random();
            //byte myByte = (byte)r.Next(10);
            Orientation direction;
            for (byte myByte = 0; myByte < 10; myByte++)
            {
                try
                {
                    direction = checked((Orientation)myByte);
                    if (direction < Orientation.North || direction > Orientation.West)
                        throw new ArgumentOutOfRangeException("myByte：" + myByte + " 只能在1到4之间");
                    WriteLine("myByte：" + myByte);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    WriteLine("Catch: " + e.Message);
                    direction = Orientation.North;
                    //throw;
                }
                //catch (Exception e)
                //{
                //    WriteLine("Catch: " + e.Message);
                //    //throw;
                //}
                finally
                {
                    WriteLine("Finally");
                    //WriteLine(direction); // 使用了未赋值的局部变量“direction”，每个路径的块中必须都有赋值
                }
                WriteLine(direction + "\n");
            }
            //WriteLine(direction + "\n"); // 使用了未赋值的局部变量“direction” ?
            WriteLine("Finished");
            ReadKey();
        }
    }
}
