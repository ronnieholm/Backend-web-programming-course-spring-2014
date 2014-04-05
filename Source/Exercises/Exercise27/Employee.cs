using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise27 {
    abstract class Employee {
        private string name;

        public Employee(string name) {
            this.name = name;
        }

        public string GetName() {
            return name;
        }

        public abstract int GetSalaryPerMonth();
        public abstract int GetBonusPerMonth();
        public abstract bool IsBonusPaidOut();
    }
}
