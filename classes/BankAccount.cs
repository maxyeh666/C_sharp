using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    {
        // 引入Transaction建立List[T]清單
        private List<Transaction> allTransactions = new List<Transaction>();

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

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            // 存款為負數時
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            // 提款為負數時
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            // 餘額不足(餘額 - 提款數 < 0)
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        public string GetAccountHistroy()
        {
            // StringBuilder
            // C#中的string為不可變動，每次改變都會重新創造一個新的字串
            // 使用StringBuilder可以將字串轉換成可以變動的方式來節省資源
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        public virtual void PerformMonthEndTransactions() {}
    }
}
