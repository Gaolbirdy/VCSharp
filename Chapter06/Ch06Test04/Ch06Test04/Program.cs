using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Test04
{
    struct Order
    {
        public string itemName;
        public int unitCount;
        public double unitCost;
        public double TotalPrice() => unitCount * unitCost;
        public override string ToString() => "Order Information: " + unitCount + " " + itemName + " items at $" + unitCost + " each,\ntotal cost $" + TotalPrice();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder;
            myOrder.itemName = "午餐";
            myOrder.unitCost = 5;
            myOrder.unitCount = 3;
            WriteLine(myOrder.ToString());
            object x = myOrder;
            WriteLine(x.ToString());
            ReadKey();
        }
    }
}
