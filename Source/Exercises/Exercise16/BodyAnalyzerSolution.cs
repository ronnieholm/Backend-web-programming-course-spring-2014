using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise16 {
    class Runner {
        public void Run() {
            BodyAnalyzerSolution b = new BodyAnalyzerSolution();
            Console.WriteLine(b.CalculateBMI(1.88, 110));
            Console.WriteLine(b.AnalyzeBMI(1.88, 40));
            Console.WriteLine(b.AnalyzeBMI(1.88, 75));
            Console.WriteLine(b.AnalyzeBMI(1.88, 90));
            Console.WriteLine(b.AnalyzeBMI(1.88, 110));
            Console.WriteLine(b.AnalyzeBMI(1.88, 130));
        }
    }

    class BodyAnalyzerSolution {
        // given the weight and height of a person returns the BMI
        public double CalculateBMI(double heightInMeters, double weightInKilo) {
            double bmi = weightInKilo / (heightInMeters * heightInMeters);
            return bmi;
        }

        // given the weight and height of a person returns a brief analyzis
        // of the BMI of the person
        public string AnalyzeBMI(double heightInMeters, double weightInKilo) {
            double bmi = CalculateBMI(heightInMeters, weightInKilo);
            string analysis = "Your BMI is : " + bmi + ", ";

            if (bmi < 15) {
                analysis += "You are way too skinny!";
            }
            else if (bmi >= 15 && bmi <= 22) {
                analysis += "You are a bit skinny";
            }
            else if (bmi > 22 && bmi <= 28) {
                analysis += "You are just fine!";
            }
            else if (bmi > 28 && bmi <= 35) {
                analysis += "You are a bit overweight!";
            }
            else {
                analysis += "You are way too fat!";
            }

            return analysis;
        }
    }
}
