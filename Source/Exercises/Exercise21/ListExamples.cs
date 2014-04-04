using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise21 {
    class ListExamples {
        public void Run() {
            List<int> aListOfInt = new List<int>();
            aListOfInt.Add(4);
            aListOfInt.Add(12);
            aListOfInt.Add(9);

            // Case 1
            // Console.WriteLine("Case 1: Element with index 1 is {0}", aListOfInt[1]);

            // Case 2
            // Console.WriteLine("Case 2: List contains {0} elements", aListOfInt.Count);

            aListOfInt.Add(5);
            aListOfInt.Add(22);

            // Case 3
            // Console.WriteLine("Case 3: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.RemoveAt(0);

            // Case 4
            // Console.WriteLine("Case 4: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.Clear();
            aListOfInt.Add(14);
            aListOfInt.Add(87);
            aListOfInt.Add(62);
            aListOfInt.Add(21);
            aListOfInt.Add(40);
            aListOfInt.Add(3);

            // Case 5: Make some code that prints out 
            // all the elements in the list

            // Case 6: Make some code that finds the 
            // sum of the elements in the list, and prints the result

            // Case 7: Make some code that finds the 
            // average of the elements in the list, and prints the result
            // Tip: Think about how average is defined; then
            // you might reuse something from Case 6

            // [DIFFICULT]
            // Case 8: Make some code that finds the
            // smallest element in the list, and prints the result
            // Tip: Think in detail about how you would do this manually
        }
    }
}
