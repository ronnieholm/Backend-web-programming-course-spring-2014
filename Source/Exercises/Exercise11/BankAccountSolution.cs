using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise11 {
    class MyCode {
        public void MyMain() {
            BankAccountSolution a = new BankAccountSolution();
            BankAccountSolution b = new BankAccountSolution("John Doe", 100.00);

            b.Deposit(12.34);
            b.Withdraw(10.00);

            Console.WriteLine(b.GetAcctountName());
            Console.WriteLine(b.GetBalance());

            b.AddInterest(0.1);
            Console.WriteLine(b.GetBalance());
        }
    }

    class BankAccountSolution {
        string accountName;
        double balance;

        public BankAccountSolution() {
            // instance fields get initialize to their default values.
            // For strings the default value is null and for doubles it's
            // 0.0
        }

        public BankAccountSolution(string accountName, double balance) {
            this.accountName = accountName;
            this.balance = balance;
        }

        public void Deposit(double amount) {
            balance += amount;
        }

        public void Withdraw(double amount) {
            balance -= amount;
        }

        public string GetAcctountName() {
            return accountName;
        }

        public double GetBalance() {
            return balance;
        }

        public void AddInterest(double interestRate) {
            // shorthand for balance = balance * interestRate;
            balance *= 1 + interestRate;
        }
    }
}
