﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise17 {
    class Runner {
        public void Run() {
            WhileLoopsSolution s = new WhileLoopsSolution();
            s.MyCode();
        }
    }

    class WhileLoopsSolution {
        public void MyCode() {
            // Case 1
            Console.WriteLine("Start of Case 1");
            int c1 = 1;
            while (c1 < 20) {
                Console.WriteLine(c1);
                c1 = c1 + 2;
            }
            Console.WriteLine("End of Case 1");

            // Case 2
            Console.WriteLine("Start of Case 2");
            int c2 = 1;
            while (c2 < 20) {
                Console.WriteLine(c2);
                c2 = c2 * 2;
            }
            Console.WriteLine("End of Case 2");

            // Case 3
            Console.WriteLine("Start of Case 3");
            int c3 = 15;
            while ((c3 < 20) && (c3 > 10)) {
                Console.WriteLine(c3); 
                c3++;
            }
            Console.WriteLine("End of Case 3");

            // Case 4
            Console.WriteLine("Start of Case 4");
            int c4 = 10;
            while (c4 >= 0) {
                Console.WriteLine(c4);
                c4--;
            }
            Console.WriteLine("End of Case 4");

            // Insert code for the below four cases

            // Case 5
            // Print out the numbers 3,5,7,9
            Console.WriteLine("Start of Case 5");
            int c5 = 3;
            while (c5 < 10) {
                Console.WriteLine(c5);
                c5 += 2;
            }
            Console.WriteLine("End of Case 5");

            // Case 6
            // Print out the numbers 0,1,3,7,15,31
            Console.WriteLine("Start of Case 6");
            int c6 = 0;
            while (c6 < 63) {
                Console.WriteLine(c6);
                c6 = 2 * c6 + 1;
            }
            Console.WriteLine("End of Case 6");

            // Case 7
            // Print out the numbers 100,50,25,12,6,3,1
            Console.WriteLine("Start of Case 7");
            int c7 = 100;
            while (c7 > 0) {
                Console.WriteLine(c7);
                c7 = c7 / 2;
            }
            Console.WriteLine("End of Case 7");

            // Case 8 (DIFFICULT)
            // Print out the numbers 10,9,12,7,14,5,16,3,18,1
            Console.WriteLine("Start of Case 8");
            int c8 = 0;
            while (c8 < 10) {
                if ((c8 % 2) == 0) {
                    Console.WriteLine(10 + c8);
                }
                else {
                    Console.WriteLine(10 - c8);
                }
                c8++;
            }
            Console.WriteLine("End of Case 8");        
        }
    }
}
