using System;

namespace classes
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initalBalance) : base(name, initalBalance) 
        {
        }

        public override void PerformMonthEndTransactions() 
        {
            if (Balance < 0)
            {
                // Negate the balance to get a postitive interest charge:
                var interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
    }
}
