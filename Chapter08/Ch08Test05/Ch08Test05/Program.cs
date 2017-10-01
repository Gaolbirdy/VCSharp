using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch08Test04;

namespace Ch08Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            CupOfCoffee coffee = new CupOfCoffee();
            CupOfTea tea = new CupOfTea();
            HaveADrink(coffee);
            HaveADrink(tea);
        }

        static void HaveADrink(HotDrink h)
        {
            h.AddMilk();
            h.Drink();
            if(h is ICup)
            {
                ICup cupOfDrink = h as ICup;
                //ICup cupOfDrink =(ICup)h;
                cupOfDrink.Wash();
            }
        }
    }
}
