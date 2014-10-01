using System;

namespace InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);

    class InterestCalculator
    {
        private decimal Money { get; set; }
        private decimal Interest { get; set; }
        private CalculateInterest Type { get; set; }
        private int Years { get; set; }

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest type)
        {
            this.Years = years;
            this.Type = type;
            this.Interest = interest;
            this.Money = money;
        }

        public override string ToString()
        {
            return string.Format("{0:F4}", this.Type(this.Money, this.Interest, this.Years));
        }
    }
}
