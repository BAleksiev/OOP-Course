using System;

namespace HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary must be positive and bigger than zero!");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid param for work hours per day!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            return base.ToString() + " - $" + this.MoneyPerHour() + " per hour";
        }
    }
}
