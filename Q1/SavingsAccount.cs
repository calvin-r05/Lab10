using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class SavingsAccount : Account
    {
        const decimal INTEREST_RATE = 0.06M;
        public SavingsAccount(string firstName, string lastName, decimal balance, DateTime interestDate)
            : base(firstName, lastName, balance, interestDate) { }

        public override void CalculateInterest()
        {
            DateTime allowedDate = DateTime.Now.AddYears(-1);

            if (allowedDate >= InterestDate)
            {
                Balance = Balance + (Balance * INTEREST_RATE);
                InterestDate = DateTime.Now;
            }
        }
    }
}
