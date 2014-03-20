using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise16 {
    class BodyAnalyzer {
        // given the weight and height of a person returns the BMI
        public double CalculateBMI(double heightInMeters, double weightInKilo) {
            double bmi = weightInKilo / (heightInMeters * heightInMeters);
            return bmi;
        }

        // given the weight and height of a person returns a brief analyzis
        // of the BMI of the person
        public string AnalyzeBMI(double heightInMeters, double weightInKilo) {
            // the below code must be changed
            string analysis = "All people are beautiful, You are beautiful";
            return analysis;
        }
    }
}
