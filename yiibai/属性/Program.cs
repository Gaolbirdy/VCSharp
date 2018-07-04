using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 属性
{
    public abstract class Person
    {
        public abstract string Name
        {
            set;
            get;
        }
        public abstract byte Age
        {
            get;
            set;
        }
    }

    class Student : Person
    {
        private string code = "N.A";
        private string name = "not known";
        private byte age = 0;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override byte Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }

    class ExamplDemo
    {
        public static void Main()
        {
            Student s = new Student();

            s.Code = "10010";
            s.Name = "Maxsu";
            s.Age = 24;
            WriteLine("Student Info: {0}", s);

            s.Age += 1;
            WriteLine("Student Info: {0}", s.ToString());
            ReadKey();
        }
    }
}
