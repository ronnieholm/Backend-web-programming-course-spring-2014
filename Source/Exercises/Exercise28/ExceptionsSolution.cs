using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise28 {
    class SolutionRunner {
        public void Run() {
            // Create a new bank account with 25% interest rate
            // (is that legal?)
            BankAccount theAccount = null;

            try {
                theAccount = new BankAccount(25.0);
            }
            catch (IllegalInterestRateException) {
                Console.WriteLine("Too high interest rate");
            }

            try {
                theAccount.Deposit(2000);
            } catch (NegativeAmountExceptionSolution) {
                Console.WriteLine("Negative amount not allowed");
            }

            // Should this be legal?
            try {
                theAccount.Deposit(-1000);
            }
            catch (NegativeAmountExceptionSolution) {
                Console.WriteLine("Negative amount not allowed");
            }

            // Try to withdraw
            try {
                theAccount.Withdraw(3000);
            }
            catch (WithdrawAmountTooLargeException) {
                Console.WriteLine("You tried to withdraw too much money");
            }

            Console.WriteLine("Balance is now: {0}", theAccount.GetBalance());
        }
    }

    // This exception is to be thrown in case it is attempted
    // to withdraw an amount larger than the current balance
    class WithdrawAmountTooLargeExceptionSolution : Exception {
    }

    // This exception is to be thrown in case the bank account
    // is defined with an illegal interest rate
    class IllegalInterestRateExceptionSolution : Exception {
    }

    // This exception is to be thrown in case it is attempted
    // to withdraw or deposit a negative amount
    class NegativeAmountExceptionSolution : Exception {
    }

    class BankAccountSolution {
        // Balance of the account. Must not become negative.
        private double balance;

        // Interest rate of the account. Must be between 0.0 and 20.0.
        private double interestRate;

        public BankAccountSolution(double interestRate) {
            if (interestRate < 0 || interestRate > 20) {
                throw new IllegalInterestRateException();
            }

            this.interestRate = interestRate;
            this.balance = 0.0;
        }

        public void Deposit(double amount) {
            if (amount < 0) {
                throw new NegativeAmountExceptionSolution();
            }
            balance = balance + amount;
        }

        public void Withdraw(double amount) {
            if (amount < 0) {
                throw new NegativeAmountExceptionSolution();
            }
            if (balance < amount) {
                throw new WithdrawAmountTooLargeException();
            }
            balance = balance - amount;
        }

        public double GetBalance() {
            return balance;
        }
    }
}
