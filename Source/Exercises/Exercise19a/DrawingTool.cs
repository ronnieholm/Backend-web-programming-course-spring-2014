﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise19a {
    // A class for very primitive drawing...
    class DrawingTool {
        public void DrawOneStar() {
            Console.Write("*");
        }

        public void DrawOneSpace() {
            Console.Write(" ");
        }

        public void StartNewLine() {
            Console.WriteLine();
        }
    }
}
