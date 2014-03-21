using Exercises.Exercise16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
    class Program {
        static void Main(string[] args) {
            int noOfChildren = 5;
            int childSupport = 0;

            switch (noOfChildren) {
                case 0:
                    childSupport = 0;
                    break;
                case 1:
                    childSupport = 1200;
                    break;
                case 2:
                    childSupport = 2000;
                    break;
                case 3:
                    childSupport = 2600;
                    break;
                default:
                    childSupport = 3000;
                    break;
            }

            if (noOfChildren == 0) {
                childSupport = 0;
            }
            else if (noOfChildren == 1) {
                childSupport = 1200;
            }
            else if (noOfChildren == 2) {
                childSupport = 2000;
            }
            else if (noOfChildren == 3) {
                childSupport = 2600;
            }
            else if (noOfChildren > 3) {
                childSupport = 3000;
            }

            Console.WriteLine(childSupport);
        }
    }
}
