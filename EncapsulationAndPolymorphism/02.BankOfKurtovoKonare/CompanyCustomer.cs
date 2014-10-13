using System;

namespace BankOfKurtovoKonare
{
    class CompanyCustomer : Customer
    {
        private string bulstat;

        public CompanyCustomer(string name, string bulstat)
            : base(name)
        {
            this.Bulstat = bulstat;
        }

        public string Bulstat
        {
            get { return this.bulstat; }

            private set
            {
                this.bulstat = value;
            }
        }
    }
}