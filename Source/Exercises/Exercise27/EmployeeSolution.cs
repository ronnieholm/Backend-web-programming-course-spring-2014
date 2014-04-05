using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise27 {
    // 9
    class SolutionRunner {
        public void Run() {
            List<EmployeeSolution> allEmployees = new List<EmployeeSolution>();

            WorkerSolution w1 = new WorkerSolution("John", 130, 130);
            WorkerSolution w2 = new WorkerSolution("Annie", 120, 160);
            allEmployees.Add(w1);
            allEmployees.Add(w2);

            JuniorManagerSolution j1 = new JuniorManagerSolution("Steve", 25000, 6000);
            j1.SetHoursWorked(140);
            JuniorManagerSolution j2 = new JuniorManagerSolution("Tanya", 23000, 8000);
            j2.SetHoursWorked(185);
            allEmployees.Add(j1);
            allEmployees.Add(j2);

            SeniorManagerSolution s1 = new SeniorManagerSolution("Sandra", 35000, 16000);
            s1.SetPerformanceLevel(7);
            SeniorManagerSolution s2 = new SeniorManagerSolution("Olav", 38000, 12000);
            s2.SetPerformanceLevel(5);
            allEmployees.Add(s1);
            allEmployees.Add(s2);

            foreach (EmployeeSolution e in allEmployees) {
                Console.WriteLine("{0} has a salary of {1}", e.GetName(), e.GetSalaryPerMonth());
            }
        }
    }

    // 1 & 2
    abstract class EmployeeSolution {
        private string name;

        public EmployeeSolution(string name) {
            this.name = name;
        }

        public string GetName() {
            return name;
        }

        public abstract int GetSalaryPerMonth();
        public abstract int GetBonusPerMonth();
        public abstract bool IsBonusPaidOut();
    }

    // 3 & 4
    class WorkerSolution : EmployeeSolution {
        private int hourlyPay;
        private int hoursWorked;

        public WorkerSolution(string name, int hourlyPay, int hoursWorked)
            : base(name) {
            this.hourlyPay = hourlyPay;
            this.hoursWorked = hoursWorked;
        }

        public override int GetSalaryPerMonth() {
            return hourlyPay * hoursWorked;
        }

        public override int GetBonusPerMonth() {
            return 0;
        }

        public override bool IsBonusPaidOut() {
            return false;
        }
    }

    // 5 & 6
    abstract class ManagerSolution : EmployeeSolution {
        private int baseSalary;
        private int monthlyBonus;

        public ManagerSolution(string name, int baseSalary, int monthlyBonus)
            : base(name) {
            this.baseSalary = baseSalary;
            this.monthlyBonus = monthlyBonus;
        }

        public override int GetSalaryPerMonth() {
            int totalSalary = baseSalary;
            if (IsBonusPaidOut()) {
                totalSalary = totalSalary + monthlyBonus;
            }
            return totalSalary;
        }

        public override int GetBonusPerMonth() {
            return monthlyBonus;
        }
    }

    // 7
    class JuniorManagerSolution : ManagerSolution {
        private int hoursWorked;

        public JuniorManagerSolution(string name, int baseSalary, int monthlyBonus)
            : base(name, baseSalary, monthlyBonus) {
            this.hoursWorked = 0;
        }

        public void SetHoursWorked(int hoursWorked) {
            this.hoursWorked = hoursWorked;
        }

        public override bool IsBonusPaidOut() {
            return hoursWorked > 180;
        }
    }

    // 8
    class SeniorManagerSolution : ManagerSolution {
        private int performanceLevel;

        public SeniorManagerSolution(string name, int baseSalary, int monthlyBonus)
            : base(name, baseSalary, monthlyBonus) {
            this.performanceLevel = 0;
        }

        public void SetPerformanceLevel(int performanceLevel) {
            this.performanceLevel = performanceLevel;
        }

        public override bool IsBonusPaidOut() {
            return performanceLevel >= 6;
        }
    }
}
