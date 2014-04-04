using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise23 {
    class SolutionRunner {
        public void Run() {
            CarPool pool = new CarPool();

            pool.AddCarToPool(new Car("CF 32 556", "Ford", "Mondeo"));
            pool.AddCarToPool(new Car("AG 57 109", "Ford", "Fiesta"));
            pool.AddCarToPool(new Car("DE 44 006", "BMW", "320i"));

            // Pool should now contain the three cars given above
            Console.WriteLine("The Car Pool now contains:");
            pool.PrintAllCarsInPool();
            Console.WriteLine();

            pool.RemoveCarFromPool("AG 57 109");
            pool.RemoveCarFromPool("DOES NOT EXIST");

            // Pool should now contain two cars
            Console.WriteLine("The Car Pool now contains:");
            pool.PrintAllCarsInPool();
            Console.WriteLine();
        }
    }

    class CarPoolSolution {
        // This instance field will contain license pates as keys,
        // and Car objects as values
        Dictionary<string, Car> carList;

        public CarPoolSolution() {
            carList = new Dictionary<string, Car>();
        }

        // Add the given car to the car pool
        public void AddCarToPool(Car aCar) {
            carList.Add(aCar.GetLicensePlate(), aCar);
        }

        // Remove the car with the given license plate from the car pool.
        // If the license plate does not exist, do nothing
        public void RemoveCarFromPool(string licensePlate) {
            if (carList.ContainsKey(licensePlate)) {
                carList.Remove(licensePlate);
            }
        }

        // If a Car object corresponding to the given license plate exists, return it.
        // Otherwise, return null
        public Car LookupCar(string licensePlate) {
            if (carList.ContainsKey(licensePlate)) {
                return carList[licensePlate];
            } else {
                return null;
            }
        }

        // Print out all cars in the pool
        // (leave this method as it is)
        public void PrintAllCarsInPool() {
            foreach (KeyValuePair<string, Car> kvp in carList) {
                Car aCar = kvp.Value;
                Console.WriteLine("{0} is a {1} {2}", aCar.GetLicensePlate(), aCar.GetBrand(), aCar.GetModel());
            }
        }
    }
}
