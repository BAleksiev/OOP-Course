using System;

namespace BankOfKurtovoKonare
{
    public abstract class Account : IInterestCalculate, IDeposit
    {
        private Customer customer;
        private decimal monthInterest;
        private decimal balance;

        protected Account(decimal balance, decimal yearInterestInPercent, Customer customer)
        {
            this.Balance = balance;
            this.MonthInterest = yearInterestInPercent / 12 / 100;
            this.Customer = customer;
        }

        public Customer Customer
        {
            get { return this.customer; }
            private set { this.customer = value; }
        }

        public decimal MonthInterest
        {
            get { return this.monthInterest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.monthInterest = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.balance = value;
            }
        }

        public virtual decimal CalculateInterest(int periodByMonths)
        {
            var interstForPeriod = this.balance * this.monthInterest * periodByMonths;
            return interstForPeriod;
        }

        public void DepositSum(decimal sum)
        {
            if (sum < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.Balance = +sum;
        }
    }
}
