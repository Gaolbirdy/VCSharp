using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);
delegate int NumberGetter();
namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int GetNum()
        {
            return num;
        }

        static void Main()
        {
            // 创建委托实例
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            NumberGetter ng = new NumberGetter(GetNum);
            nc = nc1;
            nc += nc2;

            // 调用多播
            nc(5);
            Console.WriteLine("Value of Num: {0}", ng());

            //使用委托对象调用方法
            //nc1(25);
            //Console.WriteLine("Value of Num: {0}", ng());
            //nc2(5);
            //Console.WriteLine("Value of Num: {0}", ng());
            Console.ReadKey();
        }
    }
}
