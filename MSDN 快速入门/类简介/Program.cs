using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 类简介
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("popo", 10000);
            WriteLine($"Account {account.Number} was created for { account.Owner} with { account.Balance} initial balance.");

            account.MakeWithdrawal(11500, DateTime.Now, "Recent payment");
            WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "freind paid me back");
            WriteLine(account.Balance);

            WriteLine(DateTime.Now);
        }
    }
}
