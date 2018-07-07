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
        //    al.Add(41);
        //    al.Add(70);
        //    al.Add(133);
        //    al.Add(56);
        //    al.Add(120);
        //    al.Add(213);
        //    al.Add(90);
        //    al.Add(111);

        //    WriteLine("Capacity: {0}", al.Capacity);
        //    WriteLine("Count: {0}", al.Count);

        //    Write("Content: ");
        //    foreach (int i in al)
        //    {
        //        Write(i + " ");
        //    }

        //    WriteLine();
        //    Write("Sorted Content: ");
        //    al.Sort();
        //    foreach (int i in al)
        //    {
        //        Write(i + " ");
        //    }
        //    WriteLine();
        //}
        
        //static void Main(string[] args)
        //{
        //    Hashtable ht = new Hashtable();

        //    ht.Add("001", "Maxsu");
        //    ht.Add("002", "Andy");
        //    ht.Add("003", "Jame");
        //    ht.Add("004", "Mausambe");
        //    ht.Add("005", "Mr. Amlan");
        //    ht.Add("006", "Mr. Arif");
        //    ht.Add("007", "Ritesh");
        //    ht.Add("008", "Sukida");

        //    if (ht.ContainsValue("Nuha Ali"))
        //    {
        //        WriteLine("This student name is already in the list");
        //    }
        //    else
        //    {
        //        ht.Add("018", "Yiibai");
        //    }

        //    ICollection key = ht.Keys;

        //    foreach (string k in key)
        //    {
        //        WriteLine(k + ": " + ht[k]);
        //    }
            
        //}

        //static void Main(string[] args)
        //{
        //    SortedList sl = new SortedList();

        //    sl.Add("001", "Maxsu");
        //    sl.Add("002", "Alibaba");
        //    sl.Add("003", "Tencent");
        //    sl.Add("004", "Google");
        //    sl.Add("005", "Microsoft");
        //    sl.Add("006", "Apple");
        //    sl.Add("007", "Huawei");

        //    if (sl.ContainsValue("Yiibai"))
        //    {
        //        WriteLine("This student name is already in the list.");
        //    }
        //    else
        //    {
        //        sl.Add("008", "Yiibai");
        //    }

        //    ICollection key = sl.Keys;

        //    foreach (string k in key)
        //    {
        //        WriteLine(k + ": " + sl[k]);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Stack st = new Stack();

        //    st.Push('I');
        //    st.Push('A');
        //    st.Push('B');
        //    st.Push('I');
        //    st.Push('I');
        //    st.Push('Y');

        //    WriteLine("Current stack: ");
        //    foreach (char c in st)
        //    {
        //        Write(c + " ");
        //    }
        //    WriteLine();

        //    st.Push('Y');
        //    st.Push('M');
        //    WriteLine("The next poppable value in stack: {0}", st.Peek());
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


        //}

        //static void Main(string[] args)
        //{
        //    Queue q = new Queue();

        //    q.Enqueue('Y');
        //    q.Enqueue('I');
        //    q.Enqueue('I');
        //    q.Enqueue('B');
        //    q.Enqueue('A');
        //    q.Enqueue('I');

        //    WriteLine("Current queue: ");
        //    foreach (char c in q)
        //    {
        //        Write(c + " ");
        //    }
        //    WriteLine();
        //    q.Enqueue('.');
        //    q.Enqueue('C');
        //    q.Enqueue('O');
        //    q.Enqueue('M');
        //    WriteLine("Current queue: ");
        //    foreach (char c in q)
        //    {
        //        Write(c + " ");
        //    }

        //    WriteLine();
        //    WriteLine("Removing some values ");
        //    char ch = (char)q.Dequeue();
        //    WriteLine("The removed value: {0}", ch);
        //    ch = (char)q.Dequeue();
        //    WriteLine("The removed value: {0}", ch);

        //    WriteLine("Current queue: ");
        //    foreach (char c in q)
        //    {
        //        Write(c + " ");
        //    }

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

            WriteLine("Bit array ba1: 60");
            for (int i = 0; i < ba1.Count; i++)
            {
                Write("{0, -6} ", ba1[i]);
            }
            WriteLine();

            WriteLine("Bit array ba2: 13");
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
        }
    }
}
