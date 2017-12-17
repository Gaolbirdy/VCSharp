using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 委托
{
    delegate double Function(double x);

    class Multiplier
    {
        double factor;

        public Multiplier(double factor)
        {
            this.factor = factor;
        }

        public double Multiply(double x)
        {
            return x * factor;
        }
    }

    class DelegateExample
    {
        static double Square(double x)
        {
            return x * x;
        }

        static double[] Apply(double[] a, Function f)
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = f(a[i]);
            }
            return result;
        }

        static void Main()
        {
            double[] a = { 0.0, 0.5, 1.0 };
            double[] squares = Apply(a, Square);
            double[] sines = Apply(a, Math.Sin);
            Multiplier m = new Multiplier(2.0);
            double[] doubles = Apply(a, m.Multiply);

            foreach (double item in squares)
                WriteLine(item);
            foreach (double item in sines)
                WriteLine(item);
            foreach (double item in doubles)
                WriteLine(item);

            double[] d = Apply(a, (double x) => x * 3.0);
            foreach (double item in d)
                WriteLine(item);

            ReadKey();
        }
    }
}
