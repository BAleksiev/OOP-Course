using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BankOfKurtovoKonare
{
    class Program
    {
        static void Main(string[] args)
        {
            Account asd = new DepositAccount()
            {
                Balance = 200000,
                Customer = new IndividualCustomer() { Name = "Pesho"},
                InterestRate = 0.076m
            };

            decimal interest = asd.CalculateInterest(24);

            Console.WriteLine(interest);
        }
    }
}
