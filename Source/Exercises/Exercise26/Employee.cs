using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise26 {
    class Employee {
        private string name;
        private int salaryPerMonth;

        public Employee(string name, int salaryPerMonth) {
            this.name = name;
            this.salaryPerMonth = salaryPerMonth;
        }

        public string GetName() {
            return name;
        }

        public virtual int GetSalaryPerMonth() {
            return salaryPerMonth;
        }
    }
}
