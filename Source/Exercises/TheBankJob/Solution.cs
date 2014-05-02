using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Note: step 4 isn't part of this solution.

namespace Exercises.TheBankJob {
    class SolutionRunner {
        public void Run() {
            // Test of basis account
            Console.WriteLine();
            Console.WriteLine("Test of basis account");
            BasicAccountSolution basicAcc = new BasicAccountSolution("Mr. Basic", 1);
            PrintAccountInformation(basicAcc);

            basicAcc.Deposit(3000);
            PrintAccountInformation(basicAcc);

            basicAcc.Deposit(3000);
            basicAcc.Deposit(3000);
            basicAcc.Deposit(3000);
            basicAcc.Deposit(3000);
            PrintAccountInformation(basicAcc);

            basicAcc.Withdraw(1000);
            PrintAccountInformation(basicAcc);

            basicAcc.Withdraw(1000);
            basicAcc.Withdraw(1000);
            basicAcc.Withdraw(1000);
            basicAcc.Withdraw(1000);
            PrintAccountInformation(basicAcc);

            // Test of savings account
            Console.WriteLine();
            Console.WriteLine("Test of savings account");
            SavingsAccountSolution savingsAcc = new SavingsAccountSolution("Mr. Savings", 2, 10000);
            PrintAccountInformation(savingsAcc);

            savingsAcc.Deposit(3000);
            PrintAccountInformation(savingsAcc);

            savingsAcc.Deposit(3000);
            PrintAccountInformation(savingsAcc);
            savingsAcc.Deposit(3000);
            PrintAccountInformation(savingsAcc);
            savingsAcc.Deposit(3000);
            PrintAccountInformation(savingsAcc);
            savingsAcc.Deposit(3000);
            PrintAccountInformation(savingsAcc);

            savingsAcc.Withdraw(1000);
            PrintAccountInformation(savingsAcc);

            savingsAcc.Withdraw(1000);
            PrintAccountInformation(savingsAcc);
            savingsAcc.Withdraw(1000);
            PrintAccountInformation(savingsAcc);
            savingsAcc.Withdraw(1000);
            PrintAccountInformation(savingsAcc);
            savingsAcc.Withdraw(1000);
            PrintAccountInformation(savingsAcc);

            // Test of young limited account
            Console.WriteLine();
            Console.WriteLine("Test of young limited account");
            YoungLimitedAccountSolution ylAcc = new YoungLimitedAccountSolution("Mr. Limited", 3, 2000);
            PrintAccountInformation(ylAcc);

            ylAcc.Deposit(3000);
            PrintAccountInformation(ylAcc);

            ylAcc.Deposit(3000);
            ylAcc.Deposit(3000);
            ylAcc.Deposit(3000);
            ylAcc.Deposit(3000);
            PrintAccountInformation(ylAcc);

            ylAcc.Withdraw(1000);
            PrintAccountInformation(ylAcc);

            ylAcc.Withdraw(1000);
            PrintAccountInformation(ylAcc);
            ylAcc.Withdraw(1000);
            PrintAccountInformation(ylAcc);
            ylAcc.DailyMaintenance();
            ylAcc.Withdraw(1000);
            PrintAccountInformation(ylAcc);
            ylAcc.Withdraw(1000);
            PrintAccountInformation(ylAcc);
        }

        public void PrintAccountInformation(BasicAccountSolution acc) {
            Console.WriteLine("Account no. {0} owned by {1}, has a balance of {2} kr.", acc.GetAccountNo(), acc.GetOwnerName(), acc.GetBalance());
        }
    }

    // Fairly standard bank account implementation
    // Note however that negative amounts are not handled...
    public class BasicAccountSolution {
        private double balance;
        private string ownerName;
        private int accountNo;

        public BasicAccountSolution(string ownerName, int accountNo) {
            this.ownerName = ownerName;
            this.accountNo = accountNo;
            this.balance = 0;
        }

        public virtual void Deposit(double amount) {
            balance += amount;
        }

        public virtual void Withdraw(double amount) {
            balance -= amount;
        }

        // We assume that each bank account will need some sort of "daily maintenance",
        // like calculating interest rate, resetting limits, etc.
        // Note that some other class must call this method. It's not the bank account
        // itself that must detect that a day has passed
        public virtual void DailyMaintenance() {
        }

        public double GetBalance() {
            return balance;
        }

        public string GetOwnerName() {
            return ownerName;
        }

        public int GetAccountNo() {
            return accountNo;
        }
    }

    // Note that messages to the user are printed out directly from the methods in this class
    // which may not be the best solution for a real system.
    class SavingsAccountSolution : BasicAccountSolution {
        // The deposit limit will be updated every time a deposit is made.
        private double depositLimit;
        private int noOfWithdraws;

        // Since the exercise defines the values of these they are made constants.
        // However, they could be instance fields initialised through the constructor 
        // instead.
        private const int noOfWithdrawsLimit = 3;
        private const double withdrawFee = 25.0;

        // Note the call to the base class constructor
        public SavingsAccountSolution(string ownerName, int accountNo, double depositLimit)
            : base(ownerName, accountNo) {
            this.depositLimit = depositLimit;
            this.noOfWithdraws = 0;
        }

        public override void Deposit(double amount) {
            // Deposit only allowed if the amount is lower than (or equal to) the 
            // deposit limit (no partial deposits allowed either)
            if (amount <= depositLimit) {
                base.Deposit(amount);
                depositLimit = depositLimit - amount;
            }
            else {
                Console.WriteLine("This deposit of {0} exceeds the current deposit limit of {1}", amount, depositLimit);
            }
        }

        public override void Withdraw(double amount) {
            base.Withdraw(amount);
            noOfWithdraws++;

            // If the limit for withdrawals has been exceeded, a fee is charged
            if (noOfWithdraws > noOfWithdrawsLimit) {
                base.Withdraw(withdrawFee);
                Console.WriteLine("You have beed charged a fee of {0} for your withdrawal", withdrawFee);
            }
        }
    }

    // Note that messages to the user are printed out directly from the methods in this class
    // which may not be the best solution for a real system...
    class YoungLimitedAccountSolution : BasicAccountSolution {
        // We need to store the original withdraw limit,
        // so we can reset back to it
        private double dailyWithdrawLimit;
        private double dailyWithdrawLeft;

        // Note the call to the base class constructor
        public YoungLimitedAccountSolution(string ownerName, int accountNo, double dailyWithdrawLimit)
            : base(ownerName, accountNo) {
            this.dailyWithdrawLimit = dailyWithdrawLimit;
            this.dailyWithdrawLeft = dailyWithdrawLimit;
        }

        public override void Withdraw(double amount) {
            // Withdraw only allowed if the amount is lower than (or equal to) the remaining withdraw limit
            // (no partial withdraws allowed either)
            if (amount <= dailyWithdrawLeft) {
                base.Withdraw(amount);
                dailyWithdrawLeft = dailyWithdrawLeft - amount;
            }
            else {
                Console.WriteLine("The withdrawal of {0} kr. would cause you to exceed your daily withdraw limit", amount);
            }
        }

        // Resets back to the original withdraw limit
        public override void DailyMaintenance() {
            base.DailyMaintenance();
            this.dailyWithdrawLeft = dailyWithdrawLimit;
        }
    }
}
