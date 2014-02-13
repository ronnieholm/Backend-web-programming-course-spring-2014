using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise5 {
    class LogicExpressions {
        public void MyCode() {
            // Case 1
            int a = 12;
            bool bool1 = (a != 11);
            // Console.WriteLine("The value of bool1 is : {0}", bool1);

            // Case 2
            bool bool2 = (a <= 12);
            // Console.WriteLine("The value of bool2 is : {0}", bool2);

            // Case 3
            int b = 5;
            bool bool3 = (a > 10) && (b > 10);
            // Console.WriteLine("The value of bool3 is : {0}", bool3);

            // Case 4
            bool bool4 = (a > 10) || (b > 10);
            // Console.WriteLine("The value of bool4 is : {0}", bool4);

            // Case 5
            double da = 1.2001;
            double db = (da * 2.0) / 2.0;
            bool bool5 = (da == db);
            // Console.WriteLine("The value of bool5 is : {0}", bool5);

            // Case 6 - slightly cryptic :-)
            double x = 2.0;
            double y = Math.Sqrt(x) * Math.Sqrt(x); // Math.Sqrt(...) means "the square root of..."
            bool bool6 = (x == y);
            // Console.WriteLine("The value of bool6 is : {0}", bool6);
            //
            // Why did that happen!? Check the values for x and y
            // by uncommenting the three lines below:
            //
            // Console.WriteLine("x is : {0}", x);
            // Console.WriteLine("y is : {0}", y);
            // Console.WriteLine("x - y is : {0}", (x - y));

            // Case 7
            string aStr = "Hello";
            string bStr = "Hello ";
            bool bool7 = aStr.Equals(bStr);
            // Console.WriteLine("The value of bool7 is : {0}", bool7);

            // case 8
            bool bool8 = aStr.Equals("Hello");
            // Console.WriteLine("The value of bool8 is : {0}", bool8);
        }
    }
}
