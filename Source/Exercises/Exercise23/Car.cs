using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise23 {
    class Car {
        private string licensePlate;
        private string brand;
        private string model;

        public Car(string plate, string brand, string model) {
            this.licensePlate = plate;
            this.brand = brand;
            this.model = model;
        }

        public string GetLicensePlate() {
            return licensePlate;
        }

        public string GetBrand() {
            return brand;
        }

        public string GetModel() {
            return model;
        }
    }
}
