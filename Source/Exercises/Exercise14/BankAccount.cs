using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise14 {
    class BankAccount {
        private double balance;

        public BankAccount() {
            balance = 0;
        }

        public void Deposit(double amount) {
            balance = balance + amount;
        }

        public void Withdraw(double amount) {
            balance = balance - amount;
        }

        public double GetBalance() {
            return balance;
        }
    }
}
