using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;

namespace 反序列化
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;

        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }

    //public class SerializeExample
    //{
    //    public static void Main(string[] args)
    //    {
    //        FileStream stream = new FileStream("serialize.txt", FileMode.OpenOrCreate);
    //        BinaryFormatter fomatter = new BinaryFormatter();

    //        Student s = new Student(1010, "totti");

    //        fomatter.Serialize(stream, s);

    //        stream.Close();
    //        WriteLine("序列化完成");
    //    }
    //}

    public class DeserializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("serialize.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = (Student)formatter.Deserialize(stream);

            WriteLine("Rollno: " + s.rollno);
            WriteLine("Name: " + s.name);
            WriteLine("反序列化完成");

            stream.Close();
        }
    }
}
