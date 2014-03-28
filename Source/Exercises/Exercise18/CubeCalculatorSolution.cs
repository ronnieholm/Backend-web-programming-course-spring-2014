using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise18 {
    class SolutionRunner {
        public void Run() {
            CubeCalculatorSolution cc = new CubeCalculatorSolution();

            string userInput = "";
            do {
                userInput = cc.GetUserInput("Please enter a number (or q for quit): ");
                if (cc.IsANumber(userInput)) {
                    int value = cc.ConvertToNumber(userInput);
                    int result = cc.CalculateCube(value);
                    Console.WriteLine("The cube of {0} is {1}", value, result);
                }
                else {
                    Console.WriteLine("Could not calculate");
                }
            } while (userInput != "q");
        }
    }

    class CubeCalculatorSolution {
        // reads the user's input from the console
        public String GetUserInput(String helpText) {
            Console.Write(helpText + " ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        // checks if the given string can be converted into an integer
        public bool IsANumber(String userInput) {
            try {
                Int32.Parse(userInput);
                return true;
            }
            catch (FormatException) {
                return false;
            }
        }

        // converts the given string into an integer
        public int ConvertToNumber(string userInput) {
            return Int32.Parse(userInput);
        }

        // calculates the cube of the given integer
        public int CalculateCube(int value) {
            return value * value * value;
        }
    }
}
