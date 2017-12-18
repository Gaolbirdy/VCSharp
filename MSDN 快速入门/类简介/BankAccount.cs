using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类简介
{
    //1.用一个 10 位数唯一标识银行帐户。
    //2.用字符串存储一个或多个所有者名称。
    //3.可以检索余额。
    //4.接受存款。
    //5.接受取款。
    //6.初始余额必须是正数。
    //7.取款后的余额不能是负数。
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal  must be positive");
            if (Balance - amount < 0)
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            //this.Balance = initialBalance;
        }
    }
}
