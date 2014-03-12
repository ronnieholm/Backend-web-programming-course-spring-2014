using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise07 {
    /* make use of class from Main method like so:

        Car myCar = new Car();

        // Print data about my car (BEFORE setting the values)
        // Note that we call some of the "Get..." methods here
        Console.WriteLine("Car data BEFORE setting values");
        Console.WriteLine("Car data: brand is {0}, model is {1}, engine effect is {2}",
            myCar.GetBrand(), myCar.GetModelName(), myCar.GetEngineEffectInkW());
        Console.WriteLine("");

        // We now call some of the "Set..." methods:
        myCar.SetBrand("Volvo");
        myCar.SetModelName("V40");
        myCar.SetHorsePower(145.0);

        // Print data about my car (AFTER setting the values)
        // Note that we call some of the "Get..." methods here
        Console.WriteLine("Car data AFTER setting values");
        Console.WriteLine("Car data: brand is {0}, model is {1}, engine effect is {2}",
            myCar.GetBrand(), myCar.GetModelName(), myCar.GetEngineEffectInkW());
        Console.WriteLine("");
            
        // Now we create an additional Car object, but in a different way...
        Car yourCar = new Car("BMW", "520i", 220.0);

        // Print data about your car
        // Note that we call some of the "Get..." methods here
        Console.WriteLine("Car data using alternative constructor");
        Console.WriteLine("Car data: brand is {0}, model is {1}, engine effect is {2}",
            yourCar.GetBrand(), yourCar.GetModelName(), yourCar.GetEngineEffectInkW());
        Console.WriteLine("");
    */

    class Car {
        private string brand;
        private string modelName;
        private double horsePower;

        // This constructor creates a Car object where fields are set to "empty" values
        public Car() {
            brand = "not set";
            modelName = "not set";
            horsePower = 0.0;
        }

        // This constructor creates a Car object where all fields are set,
        // using the values provided in the parameter list
        public Car(string brand, string modelName, double horsePower) {
            this.brand = brand;
            this.modelName = modelName;
            this.horsePower = horsePower;
        }

        // Sets the value of the "brand" field
        public void SetBrand(string brand) {
            this.brand = brand;
        }

        // Sets the value of the "modelName" field
        public void SetModelName(string modelName) {
            this.modelName = modelName;
        }

        // Sets the value of the "horsePower" field
        public void SetHorsePower(double horsePower) {
            this.horsePower = horsePower;
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

        // Calculates the engine effect in kilo-watts (kW),
        // and returns that value to the caller
        public double GetEngineEffectInkW() {
            double effect = horsePower * 0.745699872;    // I Googled it!
            return effect;
        }
    }
}
