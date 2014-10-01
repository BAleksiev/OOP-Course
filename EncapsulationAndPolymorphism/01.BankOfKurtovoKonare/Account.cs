using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BankOfKurtovoKonare
{
    public abstract class Account
    {
        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public virtual void Deposit(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.Balance += sum;
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal interestForPeriod = this.Balance * (this.InterestRate * months) / 12;

            return interestForPeriod;
        }
    }
}
