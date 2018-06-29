using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfaceApplication
{
    public interface ITransactions
    {
        void ShowTransaction();
        double GetAmount();
    }

    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void ShowTransaction()
        {
            WriteLine("Transaction: {0}", tCode);
            WriteLine("Date: {0}", date);
            WriteLine("Amount: {0}", GetAmount());
        }
    }

    class Tester
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("1001", "8/10/2017", 578998.00);
            Transaction t2 = new Transaction("1002", "9/10/2018", 5471980.00);
            t1.ShowTransaction();
            t2.ShowTransaction();
        }
    }
}
