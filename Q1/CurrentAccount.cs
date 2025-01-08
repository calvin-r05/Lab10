using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class CurrentAccount : Account
    {
        const decimal INTEREST_RATE = 0.03M;
        public CurrentAccount(string firstName, string lastName, decimal balance, DateTime interestDate)
            : base (firstName, lastName, balance, interestDate) { }

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
