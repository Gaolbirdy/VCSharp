using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch06Ex05
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);

        static double Mutiply(double param1, double param2) => param1 * param2;

        static double Divide(double param1, double param2) => param1 / param2;

        static double ExecuteFunction(ProcessDelegate process) => process(9, 3);
        
        static void Main(string[] args)
        {
            ProcessDelegate process;

            WriteLine("Enter 2 numbers separated with a comma:");
            string input = ReadLine();

            int commaPos = input.IndexOf(',');
            double param1 = ToDouble(input.Substring(0, commaPos));
            double param2 = ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            //double param2 = ToDouble(input.Substring(commaPos + 1, input.Length - (commaPos + 1)));

            
            WriteLine();
            WriteLine($"commaPos : {commaPos}");
            WriteLine(input.Length);
            WriteLine(param1);
            WriteLine(param2);
            WriteLine();
            

            WriteLine("Enter M to mutiplyr or D to divide:");
            input = ReadLine().ToUpper();
            if (input == "M")
                process = new ProcessDelegate(Mutiply);
                //process = Mutiply;
            else
                //process = new ProcessDelegate(Divide);
                process = Divide;
            WriteLine($"Result {process.GetType()} : {process(param1, param2)}");
            WriteLine(ExecuteFunction(process));
            
            ReadKey();
        }
    }
}
