using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise8 {
    class Student {
        private int[] testScores;
        private int noOfTestsTaken;
        private string name;

        // Creates a Student object with the provided name
        // The number of tests is initially 0 (zero)
        public Student(string name) {
            this.name = name;
            noOfTestsTaken = 0;
            testScores = new int[50];
        }

        // Add a single test score. A score is a number between
        // 0 and 100
        public void AddTestScore(int score) {
            testScores[noOfTestsTaken] = score;
            noOfTestsTaken++;
        }

        // Return the name of the student
        public String GetName() {
            return name;
        }

        // Return the number of tests the student has taken
        public int GetNumberOfTestsTaken() {
            return noOfTestsTaken;
        }

        // Calculate and return the average value of the scores 
        // for the tests the student has taken
        public int GetAverageTestScore() {
            if (noOfTestsTaken == 0) {
                return 0;
            }
            else {
                int sum = 0;
                for (int index = 0; index < noOfTestsTaken; index++) {
                    sum = sum + testScores[index];
                }
                int average = sum / noOfTestsTaken;

                return average;
            }
        }
    }
}
