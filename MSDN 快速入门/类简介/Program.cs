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

            account.MakeWithdrawal(500, DateTime.Now, "Recent payment");
            WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "freind paid me back");
            WriteLine(account.Balance);

            // Test that the initial balances must be positive:
            BankAccount invalidAccount = new BankAccount("invalid", 0);
            invalidAccount.MakeDeposit(0, DateTime.Now, "0 Deposit");
            invalidAccount.MakeWithdrawal(0, DateTime.Now, "0 Withdrawal");

            try
            {
                //invalidAccount = new BankAccount("invalid", 55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                WriteLine("Exception caught creating account with negative balance");
                WriteLine(e.ToString());
               
                //WriteLine();
                //WriteLine(e);
                //WriteLine();
                //WriteLine(e.Message);
            }

            // Test for a negative balance
            try
            {
                account.MakeWithdrawal(1750, DateTime.Now, "Attemp to overdraw");
            }
            catch (InvalidOperationException e)
            {
                WriteLine("Exception caught trying to overdraw");
                WriteLine(e.ToString());
            }

            WriteLine();
            WriteLine(account.GetAccountHistory());
            WriteLine(invalidAccount.GetAccountHistory());

            //WriteLine(DateTime.Now);

            ReadKey();
        }
    }
}
