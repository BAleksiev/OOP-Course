using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BankOfKurtovoKonare
{
    public class DepositAccount : Account
    {
        public virtual void Withdraw(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (this.Balance - sum < 0)
            {
                throw new InvalidOperationException("Unsificient balance!");
            }
            this.Balance += sum;
        }

        public override decimal CalculateInterest(int months)
        {
            return base.CalculateInterest(months);
        }
    }
}
