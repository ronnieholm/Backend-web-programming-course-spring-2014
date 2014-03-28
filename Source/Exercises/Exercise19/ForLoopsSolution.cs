using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise19 {
    class ForLoopsSolution {
        public void Run() {
            // Case 1
            Console.WriteLine("Start of case 1");
            for (int i = 0; i < 15; i = i + 3) {
                Console.WriteLine(i); // Uncomment to see result
            }
            Console.WriteLine("End of case 1");


            // Case 2
            Console.WriteLine("Start of case 2");
            for (int i = 10; i >= 3; i--) {
                Console.WriteLine(i); // Uncomment to see result
            }
            Console.WriteLine("End of case 2");

            // Case 3 - Change this to a for-loop!
            // int c3 = 0;
            // while (c3 < 12)
            // {
            //     c3 = c3 + 2;
            //     Console.WriteLine(c3);
            // }
            Console.WriteLine("Start of case 3");
            for (int i = 0; i < 12; i = i + 2) {
                Console.WriteLine(i + 2);
            }
            Console.WriteLine("End of case 3");


            // Case 4 - Change this to a for-loop!          
            // int c4 = 0;
            // while (c4 < 50)
            // {
            //     Console.WriteLine(c4);
            //     c4 = c4 * 2 + 2;
            // }
            Console.WriteLine("Start of case 4");
            for (int i = 0; i < 50; i = i * 2 + 2) {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of case 4");
        }
    }
}
