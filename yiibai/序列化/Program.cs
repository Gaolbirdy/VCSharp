using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;

namespace 序列化
{
    [Serializable]
    class Student
    {
        int rollno;
        string name;

        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }

    public class SerializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("serialize.txt", FileMode.OpenOrCreate);
            BinaryFormatter fomatter = new BinaryFormatter();

            Student s = new Student(1010, "Curry");

            fomatter.Serialize(stream, s);
            
            stream.Close();
        }
    }
}
