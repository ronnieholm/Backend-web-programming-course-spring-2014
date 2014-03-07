using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise9a {
    class MyCode {
        public void MyMain() {
            // 2a
            StatusSolution s = new StatusSolution("In class");

            // 2b
            Console.WriteLine(s.GetStatusText());
            Console.WriteLine(s.GetNoOfLikes());
            Console.WriteLine(s.GetNoOfDislikes());

            // 2c
            s.AddOneLike();
            s.AddOneLike();
            s.AddOneDislike();

            // 2d
            Console.WriteLine(s.GetStatusText());
            Console.WriteLine(s.GetNoOfLikes());
            Console.WriteLine(s.GetNoOfDislikes());

            // 3e
            s.ReadStatus();
            s.ReadStatus();
            Console.WriteLine(s.GetNumberOfReads());
            
            // 4
            s.ReadStatusMultiple(5);
            Console.WriteLine(s.GetNumberOfReads());
        }
    }

    class StatusSolution {
        private string statusText;
        private int likes;
        private int dislikes;

        // 3a
        private int numberOfReads;

        // Create the Status - initially, the status has zero likes
        // and zero dislikes
        public StatusSolution(string statusText) {
            this.statusText = statusText;
            this.likes = 0;
            this.dislikes = 0;

            // 3b
            numberOfReads = 0;
        }

        // 3c
        public void ReadStatus() {
            numberOfReads++;
        }

        // 3d
        public int GetNumberOfReads() {
            return numberOfReads;
        }

        // 4
        public void ReadStatusMultiple(int numberOfReads) {
            this.numberOfReads += numberOfReads;
        }

        public void AddOneLike() {
            likes = likes + 1;
        }

        public void AddOneDislike() {
            dislikes = dislikes + 1;
        }

        public string GetStatusText() {
            return statusText;
        }

        public int GetNoOfLikes() {
            return likes;
        }

        public int GetNoOfDislikes() {
            return dislikes;
        }
    }
}
