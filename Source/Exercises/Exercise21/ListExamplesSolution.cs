using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise21 {
    class ListExamplesSolution {
        public void Run() {
            List<int> aListOfInt = new List<int>();
            aListOfInt.Add(4);
            aListOfInt.Add(12);
            aListOfInt.Add(9);

            // Case 1
            Console.WriteLine("Case 1: Element with index 1 is {0}", aListOfInt[1]);

            // Case 2
            Console.WriteLine("Case 2: List contains {0} elements", aListOfInt.Count);

            aListOfInt.Add(5);
            aListOfInt.Add(22);

            // Case 3
            Console.WriteLine("Case 3: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.RemoveAt(0);

            // Case 4
            Console.WriteLine("Case 4: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.Clear();
            aListOfInt.Add(14);
            aListOfInt.Add(87);
            aListOfInt.Add(62);
            aListOfInt.Add(21);
            aListOfInt.Add(40);
            aListOfInt.Add(3);

            // Case 5: Make some code that prints out 
            // all the elements in the list
            Console.WriteLine("Start of Case 5");
            foreach (int i in aListOfInt) {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of Case 5");

            // Case 6: Make some code that finds the 
            // sum of the elements in the list, and prints the result
            Console.WriteLine("Start of Case 6");
            int sum6 = 0;
            foreach (int i in aListOfInt) {
                sum6 += i;
            }
            Console.WriteLine("Sum is : {0}", sum6);
            Console.WriteLine("End of Case 6");

            // Case 7: Make some code that finds the 
            // average of the elements in the list, and prints the result
            // Tip: Think about how average is defined; then
            // you might reuse something from Case 6
            Console.WriteLine("Start of Case 7");
            int sum7 = 0;
            foreach (int i in aListOfInt) {
                sum7 += sum7;
            }
            int average = sum7 / aListOfInt.Count;
            Console.WriteLine("Average is : {0}", average);
            Console.WriteLine("End of Case 7");

            // [DIFFICULT]
            // Case 8: Make some code that finds the
            // smallest element in the list, and prints the result
            // Tip: Think in detail about how you would do this manually
            Console.WriteLine("Start of Case 8");
            int smallest = aListOfInt[0];
            foreach (int i in aListOfInt) {
                if (i < smallest) {
                    smallest = i;
                }
            }
            Console.WriteLine("Smallest is : {0}", smallest);
            Console.WriteLine("End of Case 8");
        }
    }
}
