using System;
using System.Data;

namespace BankOfKurtovoKonare
{
    class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(decimal balance, decimal interest, Customer customer)
            : base(balance, interest, customer) { }

        public void WithdrawSum(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (this.Balance < sum)
            {
                throw new ArithmeticException("Insufficient amount.");
            }

            this.Balance = -sum;

        }

        public override decimal CalculateInterest(int periodByMonths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterest(periodByMonths);
        }
    }
}
