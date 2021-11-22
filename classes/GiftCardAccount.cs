using System;

namespace classes
{
    public class GiftCardAccount : BankAccount
    {
        private decimal _monthlyDepost = 0m;

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDepost = monthlyDeposit;
    }
}
