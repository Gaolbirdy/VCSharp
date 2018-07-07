using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;


namespace CollectionApplication
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    ArrayList al = new ArrayList();

        //    WriteLine("Adding some numbers:");
        //    al.Add(45);
        //    al.Add(78);
        //    al.Add(33);
        //    al.Add(36);
        //    al.Add(12);
        //    al.Add(23);
        //    al.Add(9);

        //    WriteLine("Capacity: {0} ", al.Capacity);
        //    WriteLine("Count: {0} ", al.Count);

        //    Write("Content: ");
        //    foreach (int i in al)
        //    {
        //        Write(i + " ");
        //    }
        //    WriteLine();
        //    Write("Sorted Contend: ");
        //    al.Sort();
        //    foreach (int i in al)
        //    {
        //        Write(i + " ");
        //    }
        //    WriteLine();
        //    ReadKey();
        //}
        
        //static void Main(string[] args)
        //{
        //    Hashtable ht = new Hashtable();

        //    ht.Add("001", "Zara Ali");
        //    ht.Add("002", "Abida Rehman");
        //    ht.Add("003", "Joe Holzner");
        //    ht.Add("004", "Mausam Benazir Nur");
        //    ht.Add("005", "M. Amlan");
        //    ht.Add("006", "M. Arif");
        //    ht.Add("007", "Ritesh Saikia");

        //    if (ht.ContainsValue("Nuha Ali"))
        //    {
        //        WriteLine("This student name is already in the list.");
        //    }
        //    else
        //    {
        //        ht.Add("008", "Nuha Ali");
        //    }

        //    ICollection key = ht.Keys;

        //    foreach (string k in key)
        //    {
        //        WriteLine(k + ":" + ht[k]);
        //    }
        //    ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    SortedList sl = new SortedList();

        //    sl.Add("001", "Zara Ali");
        //    sl.Add("002", "Abida Rehman");
        //    sl.Add("003", "Joe Holzner");
        //    sl.Add("004", "Mausam Benazir Nur");
        //    sl.Add("005", "M. Amlan");
        //    sl.Add("006", "M. Arif");
        //    sl.Add("007", "Ritesh Saikia");

        //    if (sl.ContainsValue("Nuha Ali"))
        //    {
        //        WriteLine("This student name is already in the list.");
        //    }
        //    else
        //    {
        //        sl.Add("008", "Nuha Ali");
        //    }

        //    ICollection key = sl.Keys;
        //    //WriteLine(sl.GetByIndex(1));

        //    foreach (string k in key)
        //    {
        //        WriteLine(k + ": " + sl[k]);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Stack st = new Stack();

        //    st.Push('A');
        //    st.Push('M');
        //    st.Push('G');
        //    st.Push('W');

        //    WriteLine("Current stack: ");
        //    foreach (char c in st)
        //    {
        //        Write(c + " ");
        //    }
        //    WriteLine();

        //    st.Push('V');
        //    WriteLine("The next popable value in stack: {0}", st.Peek());
        //    st.Push('H');
        //    WriteLine("The next popable value in stack: {0}", st.Peek());
        //    WriteLine("Current stack: ");
        //    foreach (char c in st)
        //    {
        //        Write(c + " ");
        //    }
        //    WriteLine();

        //    WriteLine("Removing values ");
        //    st.Pop();
        //    st.Pop();
        //    st.Pop();

        //    WriteLine("Current stack: ");
        //    foreach (char c in st)
        //    {
        //        Write(c + " ");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Queue q = new Queue();

        //    q.Enqueue('A');
        //    q.Enqueue('M');
        //    q.Enqueue('G');
        //    q.Enqueue('W');

        //    WriteLine("Current queue: ");
        //    foreach (char c in q)
        //    {
        //        Console.Write(c + " ");
        //    }
        //    WriteLine();

        //    q.Enqueue('V');
        //    q.Enqueue('H');
        //    WriteLine("Current queue: ");
        //    foreach (char c in q)
        //    {
        //        Console.Write(c + " ");
        //    }
        //    WriteLine();

        //    WriteLine("Removing some values");
        //    char ch = (char)q.Dequeue();
        //    WriteLine("The removed value: {0}", ch);
        //    ch = (char)q.Dequeue();
        //    WriteLine("The removed value: {0}", ch);
        //    ReadKey();
        //}

        static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);
            byte[] a = { 60 };
            byte[] b = { 13 };

            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            WriteLine("Bit array bai1: 60");
            for (int i = 0; i < ba1.Count; i++)
            {
                Write("{0, -6} ", ba1[i]);
            }
            WriteLine();

            WriteLine("Bit array bai2: 13");
            for (int i = 0; i < ba2.Count; i++)
            {
                Write("{0, -6} ", ba2[i]);
            }
            WriteLine();

            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);

            WriteLine("Bit array ba3 after AND operation: 12");
            for (int i = 0; i < ba3.Count; i++)
            {
                Write("{0, -6} ", ba3[i]);
            }
            WriteLine();

            ba3 = ba1.Or(ba2);
            WriteLine("Bit array ba3 after OR operation: 61");
            for (int i = 0; i < ba3.Count; i++)
            {
                Write("{0, -6} ", ba3[i]);
            }
            WriteLine();

            ReadKey();
        }
    }
}
