using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IndexerApplication
{
    class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N. A.";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size -1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size -1)
                {
                    namelist[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }

        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Maxsu";
            names[1] = "Sukida";
            names[2] = "Mark";
            names[3] = "Jame";
            names[4] = "Davinder";
            names[5] = "Lucy";
            names[6] = "Lily";

            for (int i = 0; i < IndexedNames.size; i++)
            {
                WriteLine(names[i]);
            }

            WriteLine(names["Mark"]);
            WriteLine(names["Lily"]);
            WriteLine(names["popo"]);
            WriteLine(names["none"]);

            ReadKey();
        }
    }
}
