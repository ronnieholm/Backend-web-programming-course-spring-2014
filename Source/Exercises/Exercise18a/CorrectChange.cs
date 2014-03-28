using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise18a {
    class CorrectChange {
        public void Run() {
            int amountToPay = 266;
            int paidAmount = 500;
            int changeToPayBack = paidAmount - amountToPay;

            // To keep things simple, we assume that you pay back
            // change as: 1-kr coins, 10-kr coins and 100-kr bills.

            int noOf1krCoins = 0;
            int noOf10krCoins = 0;
            int noOf100krBills = 0;

            // YOUR JOB: Add code to calculate the correct change

            Console.WriteLine("Your change is {0} 1-kr coins, {1} 10-kr coins and {2} 100-kr bills", noOf1krCoins, noOf10krCoins, noOf100krBills);
            Console.WriteLine("A total of {0} kr", changeToPayBack);
        }
    }
}
