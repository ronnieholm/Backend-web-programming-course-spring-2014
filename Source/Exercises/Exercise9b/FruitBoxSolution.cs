using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise9b {
    class MyCode {
        public void MyMain() {
            // 2a
            FruitBoxSolution f = new FruitBoxSolution(1.99, 2.99);

            // 2b
            Console.WriteLine(f.GetBoxContentDescription());

            // 2c
            f.AddApples(3);
            f.AddBananas(5);

            // 2d
            Console.WriteLine(f.GetBoxContentDescription());

            // 3
            Console.WriteLine(f.GetTotalPrice());

            // 4
            f.SetPriceForOneApple(9);
            f.SetPriceforOneBanana(10);
            Console.WriteLine(f.GetTotalPrice());
        }
    }

    // This class represents a simple box of fruit - it can only contain
    // Bananas and Apples. It also represents the price of each item. 
    class FruitBoxSolution {
        private int numberOfBananas;
        private int numberOfApples;
        private double priceForOneBanana;
        private double priceForOneApple;

        // Create the fruit box - it is empty to start with, but the prices must
        // be specified
        public FruitBoxSolution(double priceForOneBanana, double priceForOneApple) {
            this.priceForOneBanana = priceForOneBanana;
            this.priceForOneApple = priceForOneApple;
            this.numberOfBananas = 0;
            this.numberOfApples = 0;
        }

        // 3
        public double GetTotalPrice() {
            return numberOfBananas * priceForOneBanana +
                   numberOfApples * priceForOneApple;
        }

        // 4
        public void SetPriceForOneApple(double price) {
            priceForOneApple = price;
        }

        // 4
        public void SetPriceforOneBanana(double price) {
            priceForOneBanana = price;
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
