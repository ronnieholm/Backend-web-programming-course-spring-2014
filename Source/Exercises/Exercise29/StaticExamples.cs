using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise29 {
    class Runner {
        public void Run() {
            List<int> aList = new List<int>();
            aList.Add(23);
            aList.Add(86);
            aList.Add(51);
            aList.Add(11);
            aList.Add(39);

            ListMethods lm = new ListMethods();

            int smallest = lm.FindSmallestNumber(aList);
            Console.WriteLine("The smallest number in the list is: {0}", smallest);

            int average = lm.FindAverage(aList);
            Console.WriteLine("The average of the list is: {0}", average);
        }
    }

    class ListMethods {
        public int FindSmallestNumber(List<int> numbers) {
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

        public int FindAverage(List<int> numbers) {
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

    class Car {
        private string licensePlate;
        private int price;

        public Car(string licensePlate, int price) {
            this.licensePlate = licensePlate;
            this.price = price;
        }

        public string GetLicensePlate() {
            return licensePlate;
        }

        public int GetPrice() {
            return price;
        }
    }
}
