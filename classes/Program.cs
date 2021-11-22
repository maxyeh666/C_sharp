// 要使用的namespace
using System;

namespace classes
{
    class Program
    {
        // 預設進入點為Program.cs，Main初始預設執行
        static void Main(string[] args)
        {
            Console.WriteLine("Bank account test");

            var account = new BankAccount("aaa", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            // Test taht the initial must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException errorEvent)
            //{
            //    Console.WriteLine("Exception caught creating account with nagative balance");
            //    Console.WriteLine(errorEvent.ToString());
            //    return;
            //}

            // Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException errorEvent)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(errorEvent.ToString());
            //}

            Console.WriteLine(account.GetAccountHistroy());
        }
    }
}
