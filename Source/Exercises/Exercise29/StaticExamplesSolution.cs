using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise29 {
    class SolutionRunner {
        public void Run() {
            List<int> aList = new List<int>();
            aList.Add(23);
            aList.Add(86);
            aList.Add(51);
            aList.Add(11);
            aList.Add(39);

            int smallest = ListMethodsSolution.FindSmallestNumber(aList);
            Console.WriteLine("The smallest number in the list is: {0}", smallest);

            int average = ListMethodsSolution.FindAverage(aList);
            Console.WriteLine("The average of the list is: {0}", average);

            CarSolution c1 = new CarSolution("ab12345", 100);
            CarSolution c2 = new CarSolution("zy54321", 200);

            c1.GetLicensePlate();
            c2.GetLicensePlate();

            c1.GetPrice();
            c2.GetPrice();

            CarSolution.PrintUsageStatistics();
        }
    }

    class ListMethodsSolution {
        public static int FindSmallestNumber(List<int> numbers) {
            if (numbers.Count == 0) {
                throw new ArgumentException();
            }
            else {
                int smallest = numbers[0];
                for (int index = 1; index < numbers.Count; index++) {
                    if (numbers[index] < smallest) {
                        smallest = numbers[index];
                    }
                }
                return smallest;
            }
        }

        public static int FindAverage(List<int> numbers) {
            if (numbers.Count == 0) {
                throw new ArgumentException();
            }
            else {
                int sum = numbers[0];
                for (int index = 1; index < numbers.Count; index++) {
                    sum = sum + numbers[index];
                }
                return (sum / numbers.Count);
            }
        }
    }

    class CarSolution {
        private string licensePlate;
        private int price;

        private static int carSolutionCalls = 0;
        private static int getLicensePlateCalls = 0;
        private static int getPriceCalls = 0;

        public CarSolution(string licensePlate, int price) {
            this.licensePlate = licensePlate;
            this.price = price;
            carSolutionCalls++;
        }

        public string GetLicensePlate() {
            getLicensePlateCalls++;
            return licensePlate;
        }

        public int GetPrice() {
            getPriceCalls++;
            return price;
        }

        public static void PrintUsageStatistics() {
            Console.WriteLine(
                "carSolutionCalls: {0}, getLicensePlateCalls: {1}, getPriceCalls: {2}",
                carSolutionCalls, getLicensePlateCalls, getPriceCalls);
        }
    }
}
