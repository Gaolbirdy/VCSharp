using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Ch10Test01
{
    public class MyClass
    {
        protected string myString;

        public virtual string GetString() => "From My Class: " + myString;

        public string ContainedString
        {
            set
            {
                myString = value;
            }
        }
    }
}
