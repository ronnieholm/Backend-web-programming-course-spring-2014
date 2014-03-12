using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise06 {
    class LogicExpressions {
        public void MyCode() {
            int a = 7;
            int b = 12;

            // 1
            bool b1 = a < 10;

            // 2
            bool b2 = a >= 7;

            // 3
            bool b3 = a == 12;

            // 4
            bool b4 = a < 10 && a > 5;

            // 5
            bool b5 = a < 10 && b == 10;

            // 6
            bool b6 = a > 10 || b > 10;

            // 7
            bool b7 = b > 0 && b < 20 && a < 8;

            // 8
            bool b8 = (a + b) > (a - b);
        }
    }
}
