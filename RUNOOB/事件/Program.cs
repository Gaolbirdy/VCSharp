using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace SimpleEvent
//{
//    /***********发布器类***********/
//    public class EventTest
//    {
//        private int value;

//        public delegate void NumManipulationHandler();

//        public event NumManipulationHandler ChangeNum;

//        protected virtual void OnNumChanged()
//        {
//            if (ChangeNum != null)
//            {
//                ChangeNum();    /* 事件被触发 */
//            }
//            else
//            {
//                Console.WriteLine("event not fire");
//                Console.ReadKey();
//            }
//        }

//        //public bool HasEvent()
//        //{
//        //    return (ChangeNum != null) ? true : false;
//        //}

//        public EventTest()
//        {
//            int n = 5;
//            SetValue(n);
//        }

//        public void SetValue(int n)
//        {
//            if (value != n)
//            {
//                value = n;
//                OnNumChanged();
//            }
//        }
//    }

//    /***********订阅器类***********/
//    public class SubscribEvent
//    {
//        public void PrintF()
//        {
//            Console.WriteLine("event fire");
//            Console.ReadKey();
//        }
//    }

//    /***********触发***********/
//    public class MainClass
//    {
//        public static void Main()
//        {
//            EventTest e = new EventTest();  /* 实例化对象,第一次没有触发事件 */
//            SubscribEvent v = new SubscribEvent();  /* 实例化对象 */
//            e.ChangeNum += new EventTest.NumManipulationHandler(v.PrintF);  /* 注册 */
//            e.SetValue(7);
//            e.SetValue(11);
//            e.SetValue(11);
//        }
//    }
//}

namespace BoilerEventAppl
// 本实例提供一个简单的用于热水锅炉系统故障排除的应用程序。当维修工程师检查锅炉时，锅炉的温度和压力会随着维修工程师的备注自动记录到日志文件中。
{
    // boiler 类
    class Boiler
    {
        private int temp;
        private int pressure;

        public Boiler(int t, int p)
        {
            temp = t;
            pressure = p;
        }

        public int GetTemp()
        {
            return temp;
        }

        public int GetPressure()
        {
            return pressure;
        }
    }

    // 事件发布器
    class DelegateBoilerEvent
    {
        public delegate void BoilerLogHandler(string status);

        // 基于上面的委托定义事件
        public event BoilerLogHandler BoilerEventLog;

        public void LogProcess()
        {
            string remarks = "O. K";
            Boiler b = new Boiler(100, 12);
            int t = b.GetTemp();
            int p = b.GetPressure();
            if (t > 150 || t < 80 || p < 12 || p > 15)
            {
                remarks = "Need Maintenance";
            }
            OnBoilerEventLog("Logging Info:\n");
            OnBoilerEventLog("Temparature " + t + "\nPressure: " + p);
            OnBoilerEventLog("\nMessage: " + remarks);
        }

        protected void OnBoilerEventLog(string message)
        {
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }
    }

    // 该类保留写入日志文件的条款
    class BoilerInfoLogger
    {
        FileStream fs;
        StreamWriter sw;

        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }

        public void Logger(string info)
        {
            sw.WriteLine(info);
        }

        public void Close()
        {
            sw.Close();
            fs.Close();
        }
    }

    // 事件订阅器
    public class RecordBoilerInfo
    {
        static void Logger(string info)
        {
            Console.WriteLine(info);
        }//end of Logger

        static void Main()
        {
            BoilerInfoLogger fileLog = new BoilerInfoLogger("boiler.txt");
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(fileLog.Logger);
            boilerEvent.LogProcess();
            Console.ReadLine();
            fileLog.Close();
        }//end of main

    }//end of RecordBoilerInfo
}
