using System;

namespace BankOfKurtovoKonare
{
    public abstract class Customer
    {
        private string name;

        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }
    }
}
