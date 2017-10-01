using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Ch09Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            Compact c = new Compact();
            SUV s = new SUV();
            //Pickup p = new Pickup();
            PassengerTrain pt = new PassengerTrain();
            IPassengerCarrier pt2 = new PassengerTrain();
            AddPassenger(c);
            AddPassenger(s);
            AddPassenger(new Pickup());
            AddPassenger(pt);
            AddPassenger(pt2);
            Console.ReadKey();
        }

        static void AddPassenger(IPassengerCarrier carrier)
        {
            Console.WriteLine(carrier.ToString());
        }
    }
}
