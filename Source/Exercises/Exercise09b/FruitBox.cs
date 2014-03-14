using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise09b {
    class Runner {
        public void Run() {
            FruitBox b1 = new FruitBox(5, 10);
            string output = b1.GetBoxContentDescription();
            Console.WriteLine(output);
            b1.AddApples(2);
            b1.AddBananas(3);
            string output1 = b1.GetBoxContentDescription();
            Console.WriteLine(output1);
            double price = b1.GetTotalPrice();
            Console.WriteLine(price);
        }
    }

    // This class represents a simple box of fruit - it can only contain
    // Bananas and Apples. It also represents the price of each item. 
    class FruitBox {
        private int numberOfBananas;
        private int numberOfApples;
        private double priceForOneBanana;
        private double priceForOneApple;

        // Create the fruit box - it is empty to start with, but the prices must
        // be specified
        public FruitBox(double priceForOneBanana, double priceForOneApple) {
            this.priceForOneBanana = priceForOneBanana;
            this.priceForOneApple = priceForOneApple;
            this.numberOfBananas = 0;
            this.numberOfApples = 0;
        }

        public double GetTotalPrice() {
            double price = (numberOfApples * priceForOneApple) + (numberOfBananas * priceForOneBanana);
            return price;
        }

        public void AddApples(int numberOfApples) {
            this.numberOfApples = this.numberOfApples + numberOfApples;
        }

        public void AddBananas(int numberOfBananas) {
            this.numberOfBananas = this.numberOfBananas + numberOfBananas;
        }

        // Note that this method just returns a string describing the box content.
        // It does NOT print anything on the screen!
        public string GetBoxContentDescription() {
            string description = "The box contains " + numberOfBananas + " bananas and " + numberOfApples + " apples";
            return description;
        }
    }
}
