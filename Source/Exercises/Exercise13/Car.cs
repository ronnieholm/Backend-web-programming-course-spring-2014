using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise13 {
    public class Runner {
        public void Run() {
            Car car1 = new Car("Volvo", "V60", 165.0, 15.8, 5, true);
            Car car2 = new Car("BMW", "318i", 143.0, 18.2, 4, false);
            Car car3 = new Car("Skoda", "Fabia", 110.0, 19.8, 5, true);

            Console.WriteLine("The {0} {1} is a family car : {2}", car1.GetBrand(), car1.GetModelName(), car1.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car1.GetBrand(), car1.GetModelName(), car1.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car1.GetBrand(), car1.GetModelName(), car1.RentalPricePerDay());
            Console.WriteLine();

            Console.WriteLine("The {0} {1} is a family car : {2}", car2.GetBrand(), car2.GetModelName(), car2.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car2.GetBrand(), car2.GetModelName(), car2.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car2.GetBrand(), car2.GetModelName(), car2.RentalPricePerDay());
            Console.WriteLine();

            Console.WriteLine("The {0} {1} is a family car : {2}", car3.GetBrand(), car3.GetModelName(), car3.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car3.GetBrand(), car3.GetModelName(), car3.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car3.GetBrand(), car3.GetModelName(), car3.RentalPricePerDay());
        }
    }

    public class Car {
        private string brand;
        private string modelName;
        private double horsePower;
        private double kmPerLiter;
        private int noOfSeats;
        private bool hasAC;

        // This constructor creates a Car object where all fields are set,
        // using the values provided in the parameter list
        public Car(string brand, string modelName, double horsePower, double kmPerLiter, int noOfSeats, bool hasAC) {
            this.brand = brand;
            this.modelName = modelName;
            this.horsePower = horsePower;
            this.kmPerLiter = kmPerLiter;
            this.noOfSeats = noOfSeats;
            this.hasAC = hasAC;
        }

        // Returns the brand of the Car
        public string GetBrand() {
            return brand;
        }

        // Returns the model name of the Car
        public string GetModelName() {
            return modelName;
        }

        // Returns the horse power value of the Car
        public double GetHorsePower() {
            return horsePower;
        }

        // Returns the number of kilometers the car can drive
        // using one liter of gas
        public double GetKmPerLiter() {
            return kmPerLiter;
        }

        // Returns the number of seats in the Car
        public double GetSetCount() {
            return noOfSeats;
        }

        // Returns whether the car has air conditioning (AC)
        public bool HasAC() {
            return hasAC;
        }

        // Returns whether the car is considered economic
        // NOTE: Do we really need the if-statement?
        public bool IsEconomic() {
            bool isEconomic = false;

            if (kmPerLiter > 18.0) {
                isEconomic = true;
            }

            return isEconomic;
        }

        // Returns whether the car is considered a family car
        // NOTE: Do we need two if-statements for this?
        public bool IsFamilyCar() {
            bool familyCar = false;

            if (noOfSeats >= 4) {
                if (hasAC) {
                    familyCar = true;
                }
            }

            return familyCar;
        }

        // Returns the suggested rental price (per day) for the car
        // NOTE: Could something go wrong here?
        public int RentalPricePerDay() {
            int rentalPrice = 0;

            if (horsePower < 70.0) {
                rentalPrice = 400;
            }

            if ((horsePower > 70.0) && (horsePower < 120.0)) {
                rentalPrice = 550;
            }

            if ((horsePower > 120.0) && (horsePower < 200.0)) {
                rentalPrice = 700;
            }

            if (horsePower > 200.0) {
                rentalPrice = 1000;
            }

            return rentalPrice;
        }
    }
}
