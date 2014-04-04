using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise25 {
    class Runner {
        public void Run() {
            StudentInfo sInfo = new StudentInfo();

            Student anna = new Student(12, "Anna");
            Student betty = new Student(338, "Betty");
            Student carl = new Student(92, "Carl");

            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            carl.AddTestResult("English", 55);
            carl.AddTestResult("Math", 48);
            carl.AddTestResult("Biology", 70);
            carl.AddTestResult("French", 38);

            sInfo.AddStudent(anna.GetID(), anna);
            sInfo.AddStudent(betty.GetID(), betty);
            sInfo.AddStudent(carl.GetID(), carl);

            // Does the output match what you expect?
            Console.WriteLine(sInfo.GetStudentCount());
            Console.WriteLine(sInfo.GetStudent(12).GetName());
            Console.WriteLine(sInfo.GetStudent(338).GetName());
            Console.WriteLine(sInfo.GetStudent(92).GetName());
            Console.WriteLine(sInfo.GetAverageForStudent(12));
            Console.WriteLine(sInfo.GetAverageForStudent(338));
            Console.WriteLine(sInfo.GetAverageForStudent(92));
            Console.WriteLine(sInfo.GetAverageForStudent(120));
            Console.WriteLine(sInfo.GetTotalAverage());
        }
    }

    class StudentInfo {
        private Dictionary<int, Student> students;

        public StudentInfo() {
            students = new Dictionary<int, Student>();
        }

        // Return the number of students in the group of students
        public int GetStudentCount() {
            // The below must be changed
            return 0;
        }

        // Add a single student to the group of students
        public void AddStudent(int id, Student aStudent) {
            // Add code here
        }

        // Given an id, return the student with that id.
        // If no student exists with the given id, return null
        public Student GetStudent(int id) {
            // The below must be changed
            return null;
        }

        // Given an id, return the score average for the student with that id.
        // If no student exists with the given id, return 0 (zero).
        public int GetAverageForStudent(int id) {
            // The below must be changed
            return 0;
        }

        // Calculate the total test score average for ALL students
        // in the group of students.
        // TIP: Use the method GetAllStudentId and a loop...
        public int GetTotalAverage() {
            // The below must be changed
            return 0;
        }

        // Returns a list of all ids of the students in the group of students
        // (leave this method as it is)
        public List<int> GetAllStudentId() {
            // A little bit of black magic...
            return new List<int>(students.Keys.ToArray());
        }
    }
}
