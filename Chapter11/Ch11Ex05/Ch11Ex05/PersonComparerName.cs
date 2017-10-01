using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ch11Ex05
{
    public class PersonComparerName : IComparer
    {
        public static IComparer Defalut = new PersonComparerName();
        public int Compare(object x, object y)
        {
            if (x is Person && y is Person)
                return Comparer.Default.Compare(((Person)x).Name, ((Person)y).Name);
            else
            {
                throw new ArgumentException("Onr or both Objects to compare ara not Person objects.");
            }
        }
    }
}
