using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise23 {
    class Car {
        private String licensePlate;
        private String brand;
        private String model;

        public Car(String plate, String brand, String model) {
            this.licensePlate = plate;
            this.brand = brand;
            this.model = model;
        }

        public String GetLicensePlate() {
            return licensePlate;
        }

        public String GetBrand() {
            return brand;
        }

        public String GetModel() {
            return model;
        }
    }
}
