using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise10 {
    class MyCode {
        public void MyMain() {
            // 1
            Die d = new Die();
            Console.WriteLine(d.GetValue());

            d.RollDie();
            Console.WriteLine(d.GetValue());

            // 2a
            DiceCupSolution cup = new DiceCupSolution();
            cup.RollDice();

            // 2b
            Console.WriteLine(cup.GetTotalValue());

            // 2c
            Console.WriteLine(cup.IsTotalValueLargerThan(5));
        }
    }

    class DiceCupSolution {
        private Die die1;
        private Die die2;

        public DiceCupSolution() {
            // When we have instance fields of a class type,
            // we usually create actual objects in the constructor
            // that the instance fields can then point to.
            die1 = new Die();
            die2 = new Die();
        }

        // You must create a method with the below header:
        public void RollDice() {
            die1.RollDie();
            die2.RollDie();
        }

        // You must create a method with the below header:
        public int GetTotalValue() {
            return die1.GetValue() + die2.GetValue();
        }

        // You must create a method with the below header:
        public bool IsTotalValueLargerThan(int value) {
            return GetTotalValue() > value;
        }
    }
}
