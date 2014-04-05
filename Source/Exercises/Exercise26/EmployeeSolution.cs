using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise26 {
    // 5
    class SolutionRunner {
        public void Run() {
            List<EmployeeSolution> allEmployees = new List<EmployeeSolution>();

            WorkerSolution w1 = new WorkerSolution("James", 15000, "Maintenance");
            WorkerSolution w2 = new WorkerSolution("Irina", 17000, "Truck Driver");
            allEmployees.Add(w1);
            allEmployees.Add(w2);

            ManagerSolution m1 = new ManagerSolution("Johanna", 22000, 4000);
            ManagerSolution m2 = new ManagerSolution("James", 23000, 3000);
            m1.SetHoursWorked(190);
            m2.SetHoursWorked(160);
            allEmployees.Add(m1);
            allEmployees.Add(m2);

            DirectorSolution d1 = new DirectorSolution("Susan", 35000);
            DirectorSolution d2 = new DirectorSolution("Thomas", 38000);
            d1.SetHoursWorked(130);
            d2.SetHoursWorked(200);
            allEmployees.Add(d1);
            allEmployees.Add(d2);

            foreach (EmployeeSolution e in allEmployees) {
                Console.WriteLine("{0} has a salary of {1}", e.GetName(), e.GetSalaryPerMonth());
            }
        }
    }

    // 1
    class EmployeeSolution {
        private string name;
        private int salaryPerMonth;

        public EmployeeSolution(string name, int salaryPerMonth) {
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

    // 2
    class WorkerSolution : EmployeeSolution {
        private string skill;

        public WorkerSolution(string name, int salaryPerMonth, string skill)
            : base(name, salaryPerMonth) {
            this.skill = skill;
        }

        public String GetSkill() {
            return skill;
        }

        public void SetSkill(String skill) {
            this.skill = skill;
        }
    }

    // 3
    class ManagerSolution : EmployeeSolution {
        private int monthlyBonus;
        private int hoursWorked;

        public ManagerSolution(string name, int salaryPerMonth, int monthlyBonus)
            : base(name, salaryPerMonth) {
            this.monthlyBonus = monthlyBonus;
            hoursWorked = 0;
        }

        public void SetHoursWorked(int hoursWorked) {
            this.hoursWorked = hoursWorked;
        }

        public override int GetSalaryPerMonth() {
            int totalSalary = base.GetSalaryPerMonth();
            if (hoursWorked > 180) {
                totalSalary += monthlyBonus;
            }
            return totalSalary;
        }
    }

    // 4
    class DirectorSolution : ManagerSolution {
        public DirectorSolution(string name, int salaryPerMonth)
            : base(name, salaryPerMonth, 20000) {
        }
    }
}
