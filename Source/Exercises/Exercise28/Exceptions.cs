using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise28 {
    class Runner {
        public void Run() {
            // Create a new bank account with 25% interest rate
            // (is that legal?)
            BankAccount theAccount = new BankAccount(25.0);
            theAccount.Deposit(2000);

            // Should this be legal?
            theAccount.Deposit(-1000);

            // Try to withdraw
            try {
                theAccount.Withdraw(3000);
            }
            catch (WithdrawAmountTooLargeException) {
                Console.WriteLine("You tried to withdraw too much money!");
            }

            Console.WriteLine("Balance is now : {0}", theAccount.GetBalance());
        }
    }

    // This exception is to be thrown in case it is attempted
    // to withdraw an amount larger than the current balance
    class WithdrawAmountTooLargeException : Exception {
    }

    // This exception is to be thrown in case the bank account
    // is defined with an illegal interest rate
    class IllegalInterestRateException : Exception {
    }

    // This exception is to be thrown in case it is attempted
    // to withdraw or deposit a negative amount
    class NegativeAmountException : Exception {
    }

    class BankAccount {
        // Balance of the account. Must not become negative.
        private double balance;

        // Interest rate of the account. Must be between 0.0 and 20.0.
        private double interestRate;

        public BankAccount(double interestRate) {
            this.interestRate = interestRate;
            this.balance = 0.0;
        }

        public void Deposit(double amount) {
            balance = balance + amount;
        }

        public void Withdraw(double amount) {
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
