using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise3 {
    class Arithmetics {
        public void MyCode() {
            // Case 1
            int a = 20;
            a = a + 30;
            a = a / 6;
            //Console.WriteLine("The value of a is : {0}", a);

            // Case 2
            int b = 20;
            b = -b;
            b = b * 5;
            // Console.WriteLine("The value of b is : {0}", b);

            // Case 3
            int c = 50;
            c = c * -2;
            c = c + 150;
            c = c % 12;
            // Console.WriteLine("The value of c is : {0}", c);

            // Case 4
            double d = 1.50;
            d = d / 3;
            // Console.WriteLine("The value of d is : {0}", d);

            // Case 5
            double e = 2.50;
            e = e * 4.5 - 10;
            // Console.WriteLine("The value of e is : {0}", e);

            // Case 6
            double f = d * e / 20.5;
            // Console.WriteLine("The value of f is : {0}", f);

            // Case 7
            int h = (a + c) * (4 + a);
            // Console.WriteLine("The value of h is : {0}", h);

            // Case 8
            int i = a + c * 4 + a;
            // Console.WriteLine("The value of i is : {0}", i);
        }
    }
}
