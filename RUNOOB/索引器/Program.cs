using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApplication
{
    class IndexedNames
    {
        private string[] nameList = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                nameList[i] = "N. A." + i;
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "出界";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    nameList[index] = value;
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
                    if (nameList[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }

        static void Main()
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";

            //for (int i = 0; i < names.nameList.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            // 使用带有 int 参数的第一个索引器
            //for (int i = 0; i < IndexedNames.size; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            // 使用带有 string 参数的第二个索引器
            //Console.WriteLine(names["Nuha"]);
            for (int i = IndexedNames.size - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i] + " " + names[names[i]]);
            }

            Console.ReadKey();
        }
    }
}
