using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;

namespace AttributeAppl
{
    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : Attribute
    {
        private string topic = "Default";
        public readonly string Url;

        public string Topic
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
            }
        }

        public HelpAttribute(string url)
        {
            this.Url = url;
        }
    }

    [HelpAttribute("Information on the class MyClass")]
    class MyClass
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                WriteLine(attributes[i]);
                HelpAttribute ha = (HelpAttribute)attributes[i];
                WriteLine(ha.Topic);
                WriteLine(ha.Url);
            }
            ReadKey();
        }
    }
}
